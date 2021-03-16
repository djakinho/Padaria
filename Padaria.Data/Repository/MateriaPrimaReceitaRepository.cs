using Microsoft.EntityFrameworkCore;
using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Padaria.Data.Repository
{
    public class MateriaPrimaReceitaRepository : BaseRepository<MateriaPrimaReceita>, IMateriaPrimaReceitaRepository
    {
        public MateriaPrimaReceitaRepository(Contexto contexto) : base(contexto)
        {

        }
        public List<MateriaPrimaReceita> SelecionarTudoCompleto()
        {
            return _contexto.MateriaPrimaReceita
                .Include(x => x.MateriaPrima)
                .Include(x => x.Receita)
                .ToList();
        }

        public override void Adicionar(MateriaPrimaReceita entity)
        {
            // colocar regras para inclusao


            base.Adicionar(entity);
        }
    }
}