using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Linq;

namespace Padaria.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {

        }

        public Usuario SelecionarPorNomeESenha(string nome, string senha)
        {
            return _contexto.Set<Usuario>().Where(u => u.Nome == nome && u.Senha == senha).FirstOrDefault();
        }
    }
}
