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
    [Authorize(Roles = "Estoquista,Administrador")]
    public class FornecedorController : ControllerBase
    {
        private readonly IFornecedorRepository _repo;
        public FornecedorController(IFornecedorRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Fornecedor> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Fornecedor Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Fornecedor> Post([FromBody] Fornecedor fornecedor)
        {
            _repo.Adicionar(fornecedor);
            return _repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Fornecedor> Put(int id, [FromBody] Fornecedor fornecedor)
        {
            _repo.Editar(fornecedor);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Fornecedor> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}
