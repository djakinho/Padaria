using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PerfilUsuarioController : ControllerBase
    {
        private readonly IPerfilUsuarioRepository _repo;
        public PerfilUsuarioController(IPerfilUsuarioRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<PerfilUsuario> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public PerfilUsuario Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<PerfilUsuario> Post([FromBody] PerfilUsuario PerfilUsuario)
        {
            _repo.Adicionar(PerfilUsuario);
            return _repo.SelecionarTudo();
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
