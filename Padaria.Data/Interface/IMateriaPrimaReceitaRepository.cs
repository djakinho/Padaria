using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Data.Interface
{
    public interface IMateriaPrimaReceitaRepository : IBaseRepository<MateriaPrimaReceita>
    {
        List<MateriaPrimaReceita> SelecionarTudoCompleto();
    }
}