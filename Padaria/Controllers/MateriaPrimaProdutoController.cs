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
    public class MateriaPrimaProdutoController : ControllerBase

    {
        private readonly IMateriaPrimaProdutoRepository _repo;

        public MateriaPrimaProdutoController (IMateriaPrimaProdutoRepository repo)
        {
            _repo = repo;
        }
        // GET: api/<MateriaPrimaProdutoController>
        [HttpGet]
        public IEnumerable<MateriaPrimaProduto> Get()
        {
            return _repo.SelecionarTudoCompleto();
        }

        [HttpGet("{id}")]
        public MateriaPrimaProduto Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<MateriaPrimaProduto> Post([FromBody] MateriaPrimaProduto tp)
        {
            _repo.Adicionar(tp);

            return _repo.SelecionarTudo();
        }

        [HttpPut]
        public IEnumerable<MateriaPrimaProduto> Put([FromBody] MateriaPrimaProduto tp)
        {
            _repo.Editar(tp);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<MateriaPrimaProduto> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}

