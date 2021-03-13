using Minha1Conexao.Data.Repository;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Repository
{
    public class TipoProducaoRepository : BaseRepository<TipoProducao>
    {
        public TipoProducaoRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
