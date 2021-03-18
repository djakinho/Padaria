using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Repository
{
    public class ProdutoEmProducaoRepository : BaseRepository<ProdutoEmProducao>, IProdutoEmProducaoRepository
    {
        public ProdutoEmProducaoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
