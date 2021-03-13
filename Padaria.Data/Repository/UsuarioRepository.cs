using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Padaria.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {

        }
        public Usuario SelectPorNome(string nome)
        {
            var user = _contexto.Set<Usuario>().First(x => x.Nome == nome);
            return user;
        }

        public Usuario SelectPorEmail(string email)
        {
            var user = _contexto.Set<Usuario>().First(x => x.Email == email);
            return user;
        }

        public List<Usuario> SelectTodos()
        {
            var x = _contexto.Set<Usuario>().ToList();
            x.OrderBy(u => u.Nome);
            return x;
        }
    }
}
