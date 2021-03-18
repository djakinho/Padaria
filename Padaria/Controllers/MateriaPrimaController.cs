using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Estoquista,Administrador")]
    public class MateriaPrimaController : ControllerBase
    {

        private readonly IMateriaPrimaRepository _matRepo;

        public MateriaPrimaController(IMateriaPrimaRepository matRepo)
        {
            _matRepo = matRepo;
        }


       /* public async Task<IActionResult> Index()
        {
            var contexto - _contexto.MateriaPrima.Adicionar
        }
        [HttpGet]
        public IEnumerable<MateriaPrima> Get()
        {
            var matRepo = _matRepo.Materia.Adicionar(m => m.)
            return _matRepo.SelecionarTudo();
        }*/

        // GET api/<MateriaPrimaController>/5
        [HttpGet("{id}")]
        public MateriaPrima Get(int id)
        {
            return _matRepo.Selecionar(id);
        }

        // POST api/<MateriaPrimaController>
        [HttpPost]
        public IEnumerable<MateriaPrima> Post([FromBody] MateriaPrima materiaPrima)
        {
            try
            {
                if (string.IsNullOrEmpty(materiaPrima.Nome) || double.IsNaN(materiaPrima.Quantidade)) return (IEnumerable<MateriaPrima>)BadRequest("Não deixar o campo vazio");
                if (double.IsNegative(materiaPrima.Quantidade)) return (IEnumerable<MateriaPrima>)BadRequest("Valores somente positivos");

                //somar quantidadeNova + quantidadeCadastrada
                _matRepo.Adicionar(materiaPrima);
                return _matRepo.SelecionarTudo();
            }
            catch
            {
                return (IEnumerable<MateriaPrima>)StatusCode(500);
            }

        }

        // PUT api/<MateriaPrimaController>/5
        [HttpPut("{id}")]
        public IEnumerable<MateriaPrima> Put(int id, [FromBody] MateriaPrima materiaPrima)
        {
            try
            {

                if (string.IsNullOrEmpty(materiaPrima.Nome) || double.IsNaN(materiaPrima.Quantidade)) return (IEnumerable<MateriaPrima>)BadRequest("Não deixar o campo vazio");
                if (double.IsNegative(materiaPrima.Quantidade)) return (IEnumerable<MateriaPrima>)BadRequest("Valores somente positivos");


                _matRepo.Editar(materiaPrima);
                return _matRepo.SelecionarTudo();
            }
            catch
            {
                return (IEnumerable<MateriaPrima>)StatusCode(500);
            }
        }

        private IEnumerable<MateriaPrima> Delete(int id)
        {
            //se IdMateriaPrima == IdProduto não pode apagar

            _matRepo.Apagar(id);
            return _matRepo.SelecionarTudo();
        }
    }
}
