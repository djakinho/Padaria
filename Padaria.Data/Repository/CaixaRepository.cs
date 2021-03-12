using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Repository
{
    public class CaixaRepository : BaseRepository<Caixa>, ICaixaRepository
    {
        public CaixaRepository(Contexto contexto) : base(contexto)
        {

        }
    }
}
