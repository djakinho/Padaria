using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repo;
        public UsuarioController(IUsuarioRepository repo)
        {
            _repo = repo;
        }
        [HttpGet("{select}")]
        public IActionResult Get(string select)
        {
            try
            {
                if (string.IsNullOrEmpty(select))
                    return Ok(_repo.SelectTodos());
                else
                    if (_repo.SelectPorNome(select).Nome != "" || _repo.SelectPorNome(select) != null)
                    return Ok(_repo.SelectPorNome(select));
                else if (_repo.SelectPorEmail(select).Email != "" || _repo.SelectPorNome(select) != null)
                    return Ok(_repo.SelectPorEmail(select));

                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_repo.Selecionar(id));
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Usuario Usuario)
        {
            try
            {
                _repo.Adicionar(Usuario);
                return Ok("Operação Concluida");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Usuario Usuario)
        {
            try
            {
                _repo.Editar(Usuario);
                return Ok("Operação Concluida");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repo.Apagar(id);
                return Ok("Operação Concluida");
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }

        }
    }
}
