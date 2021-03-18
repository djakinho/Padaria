using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;

namespace Padaria.Data.Repository
{
    public class TipoProducaoRepository : BaseRepository<TipoProducao>, ITipoProducaoRepository
    {
        public TipoProducaoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
