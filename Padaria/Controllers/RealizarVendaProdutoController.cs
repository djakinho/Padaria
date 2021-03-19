using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Domain.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Estoquista,Administrador")]
    public class RealizarVendaProdutoController : ControllerBase

    {
        private readonly IRealizarVendaProdutoRepository _repo;

        public RealizarVendaProdutoController(IRealizarVendaProdutoRepository repo)
        {
            _repo = repo;
        }
        // GET: api/<MateriaPrimaProdutoController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repo.SelecionarTudoCompleto());
            }
            catch(System.Exception)
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
        public IActionResult Post([FromBody] RealizarVendaProduto tp)
        {
            try
            {
                _repo.Adicionar(tp);
                return Ok(_repo.SelecionarTudo());
            }
            catch (System.Exception)
            {
                return StatusCode(500);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] RealizarVendaProduto tp)
        {
            try
            {
                _repo.Editar(tp);
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

