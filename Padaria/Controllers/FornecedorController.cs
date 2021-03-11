using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedorController : ControllerBase
    {
        private readonly FornecedorRepository repo;
        public FornecedorController()
        {
            repo = new FornecedorRepository();
        }

        // GET: api/<FornecedorController>
        [HttpGet]
        public IEnumerable<Fornecedor> Get()
        {
            return repo.SelecionarTudo();
        }

        // GET api/<FornecedorController>/5
        [HttpGet("{id}")]
        public Fornecedor Get(int id)
        {
            return repo.Selecionar(id);
        }

        // POST api/<FornecedorController>
        [HttpPost]
        public IEnumerable<Fornecedor> Post([FromBody] Fornecedor fornecedor)
        {
            repo.Adicionar(fornecedor);
            return repo.SelecionarTudo();
        }

        // PUT api/<FornecedorController>/5
        [HttpPut("{id}")]
        public IEnumerable<Fornecedor> Put(int id, [FromBody] Fornecedor fornecedor)
        {
            repo.Editar(fornecedor);
            return repo.SelecionarTudo();
        }

        // DELETE api/<FornecedorController>/5
        [HttpDelete("{id}")]
        public IEnumerable<Fornecedor> Delete(int id)
        {
            repo.Apagar(id);
            return repo.SelecionarTudo();
        }
    }
}
