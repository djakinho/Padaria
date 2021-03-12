using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;

namespace Padaria.Data.Repository
{
    public class PerfilUsuarioRepository : BaseRepository<PerfilUsuario>, IPerfilUsuarioRepository
    {
        public PerfilUsuarioRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
