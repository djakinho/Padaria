using Minha1Conexao.Data.Repository;
using Padaria.Domain.Model;

namespace Padaria.Data.Repository
{
    public class EstoqueProdutoRepository : BaseRepository<EstoqueProduto>, IEstoqueProdutoRepository
    {
        public EstoqueProdutoRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
