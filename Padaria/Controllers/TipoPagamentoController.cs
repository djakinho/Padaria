using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Vendedor,Administrador")]
    public class TipoPagamentoController : ControllerBase
    {
        private readonly ITipoPagamentoRepository _repo;
        public TipoPagamentoController(ITipoPagamentoRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<TipoPagamento> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public TipoPagamento Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<TipoPagamento> Post([FromBody] TipoPagamento tipoPagamento)
        {
            _repo.Adicionar(tipoPagamento);
            return _repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<TipoPagamento> Put(int id, [FromBody] TipoPagamento tipoPagamento)
        {
            _repo.Editar(tipoPagamento);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<TipoPagamento> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}
