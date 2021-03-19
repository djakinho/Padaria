using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Padaria.Data.Repository
{

    public class RealizarVendaProdutoRepository : BaseRepository<RealizarVendaProduto>, IRealizarVendaProdutoRepository
    {
        public RealizarVendaProdutoRepository(Contexto contexto) : base(contexto)
        {

        }
        public List<RealizarVendaProduto> SelecionarTudoCompleto()
        {
            return _contexto.RealizarVendaProduto
                .Include(x => x.RealizarVenda)
                .Include(x => x.Produto)
                .ToList();
        }

        public override void Adicionar(RealizarVendaProduto entity)
        {
            // colocar regras para inclusao


            base.Adicionar(entity);
        }
    }
}

