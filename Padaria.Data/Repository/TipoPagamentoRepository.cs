using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;

namespace Padaria.Data.Repository
{
    public class TipoPagamentoRepository : BaseRepository<TipoPagamento>, ITipoPagamentoRepository
    {
        public TipoPagamentoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
