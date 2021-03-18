using Padaria.Domain.Model;
using System;

namespace Padaria.Data.Interface
{
    public interface IMateriaPrimaRepository : IBaseRepository<MateriaPrima>
    {
        Usuario SelecionarPorNomeESenha(string nome, string senha);
        bool Any(Func<object, bool> p);
    }
}
