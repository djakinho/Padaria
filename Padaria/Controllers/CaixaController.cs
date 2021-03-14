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
    [Authorize(Roles = "Vendedor,Administrador")]
    public class CaixaController : ControllerBase
    {
        private readonly ICaixaRepository _repo;
        public CaixaController(ICaixaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Caixa> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Caixa Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Caixa> Post([FromBody] Caixa Caixa)
        {
            _repo.Adicionar(Caixa);
            return _repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Caixa> Put(int id, [FromBody] Caixa Caixa)
        {
            _repo.Editar(Caixa);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Caixa> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}
