using Minha1Conexao.Data.Repository;
using Padaria.Domain.Model;

namespace Padaria.Data.Repository
{
    public class FechamentoCaixaRepository : BaseRepository<FechamentoCaixa>, IFechamentoCaixaRepository
    {
        public FechamentoCaixaRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
