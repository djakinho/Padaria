using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Repository
{
    public class UnidadeMedidaRepository : BaseRepository<UnidadeMedida>, IUnidadeMedidaRepository
    {
        public UnidadeMedidaRepository(Contexto contexto) : base(contexto)
        {
        }
    }
}
