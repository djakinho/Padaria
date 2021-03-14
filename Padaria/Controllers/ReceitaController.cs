using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Estoquista,Administrador")]
    public class ReceitaController : ControllerBase
    {
        private readonly IReceitaRepository _repo;
        public ReceitaController(IReceitaRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Receita> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Receita Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Receita> Post([FromBody] Receita fornecedor)
        {
            _repo.Adicionar(fornecedor);
            return _repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Receita> Put(int id, [FromBody] Receita receita)
        {
            _repo.Editar(receita);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Receita> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}
