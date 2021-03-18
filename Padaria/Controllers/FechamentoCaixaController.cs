using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Repository;
using Padaria.Domain.Model;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Vendedor,Administrador")]
    public class FechamentoCaixaController : ControllerBase
    {
        private readonly IFechamentoCaixaRepository _repo;
        public FechamentoCaixaController(IFechamentoCaixaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.SelecionarTudo());
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
        public IActionResult Post([FromBody] FechamentoCaixa fechamentoCaixa)
        {
            try
            {
                _repo.Adicionar(fechamentoCaixa);
                return Ok(_repo.SelecionarTudo());
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] FechamentoCaixa fechamentoCaixa)
        {
            try
            {
                _repo.Editar(fechamentoCaixa);
                return Ok(_repo.SelecionarTudo());
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
                return Ok(_repo.SelecionarTudo());
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
