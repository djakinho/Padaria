using Microsoft.AspNetCore.Mvc;
using Padaria.Data.Interface;
using Padaria.Data.Repository;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _repo;
        public UsuarioController(IUsuarioRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _repo.SelecionarTudo();
        }

        [HttpGet("{id}")]
        public Usuario Get(int id)
        {
            return _repo.Selecionar(id);
        }

        [HttpPost]
        public IEnumerable<Usuario> Post([FromBody] Usuario Usuario)
        {
            _repo.Adicionar(Usuario);
            return _repo.SelecionarTudo();
        }

        [HttpPut("{id}")]
        public IEnumerable<Usuario> Put(int id, [FromBody] Usuario Usuario)
        {
            _repo.Editar(Usuario);
            return _repo.SelecionarTudo();
        }

        [HttpDelete("{id}")]
        public IEnumerable<Usuario> Delete(int id)
        {
            _repo.Apagar(id);
            return _repo.SelecionarTudo();
        }
    }
}
