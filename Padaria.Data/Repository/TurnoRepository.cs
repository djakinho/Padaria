using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;

namespace Padaria.Data.Repository
{
    public class TurnoRepository : BaseRepository<Turno>, ITurnoRepository
    {
        public TurnoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
