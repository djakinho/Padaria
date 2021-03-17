using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Data.Repository
{

    public class MateriaPrimaProdutoRepository : BaseRepository<MateriaPrimaProduto>, IMateriaPrimaProdutoRepository
    {
        public MateriaPrimaProdutoRepository(Contexto contexto) : base(contexto)
        {

        }
        public List<MateriaPrimaProduto> SelecionarTudoCompleto()
        {
            return _contexto.MateriaPrimaProduto
                .Include(x => x.MateriaPrima)
                .Include(x => x.Produto)
                .ToList();
        }

        public override void Adicionar(MateriaPrimaProduto entity)
        {
            // colocar regras para inclusao


            base.Adicionar(entity);
        }
    }
}

