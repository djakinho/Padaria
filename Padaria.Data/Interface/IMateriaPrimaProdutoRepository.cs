using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Data.Interface
{
    public interface IMateriaPrimaProdutoRepository : IBaseRepository<MateriaPrimaProduto>
    {
        List<MateriaPrimaProduto> SelecionarTudoCompleto();
    }
}
