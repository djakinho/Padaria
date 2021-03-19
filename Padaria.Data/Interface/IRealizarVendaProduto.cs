using Padaria.Domain.Model;
using System.Collections.Generic;

namespace Padaria.Data.Interface
{
    public interface IRealizarVendaProdutoRepository : IBaseRepository<RealizarVendaProduto>
    {
        List<RealizarVendaProduto> SelecionarTudoCompleto();
    }
}
