using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Estoquista,Administrador")]
    public class MateriaPrimaReceitaController : ControllerBase

    {
        private readonly IMateriaPrimaReceitaRepository _repo;

        public MateriaPrimaReceitaController(IMateriaPrimaReceitaRepository repo)
        {
            _repo = repo;
        }
        // GET: api/<MateriaPrimaProdutoController>
        [HttpGet]
        public IEnumerable<MateriaPrimaReceita> Get()
        {
            return _repo.SelecionarTudoCompleto();
        }

        [HttpGet("{id}")]
        public MateriaPrimaReceita Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<MateriaPrimaReceita> Post([FromBody] MateriaPrimaReceita tp)
        {
            _repo.Adicionar(tp);

            return _repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<MateriaPrimaReceita> Put([FromBody] MateriaPrimaReceita tp)
        {
            _repo.Editar(tp);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<MateriaPrimaReceita> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}

