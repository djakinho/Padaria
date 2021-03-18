using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Repository
{
    public class MateriaPrimaRepository : BaseRepository<MateriaPrima>, IMateriaPrimaRepository
    {
        public MateriaPrimaRepository(Contexto contexto) : base(contexto)
        {
        }

        public bool Any(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public Usuario SelecionarPorNomeESenha(string nome, string senha)
        {
            throw new NotImplementedException();
        }
    }
}
