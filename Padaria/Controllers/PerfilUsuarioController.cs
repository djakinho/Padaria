using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrador")]
    public class PerfilUsuarioController : ControllerBase
    {
        private readonly IPerfilUsuarioRepository _repo;
        public PerfilUsuarioController(IPerfilUsuarioRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.SelecionarTudo());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("Por favor, entre um Id válido");
                }
                return Ok(_repo.Selecionar(id));
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] PerfilUsuario PerfilUsuario)
        {
            _repo.Adicionar(PerfilUsuario);
            return Ok(_repo.SelecionarTudo());
        }

        [HttpPut("{id}")]
        public IEnumerable<PerfilUsuario> Put(int id, [FromBody] PerfilUsuario PerfilUsuario)
        {
            _repo.Editar(PerfilUsuario);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<PerfilUsuario> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}
