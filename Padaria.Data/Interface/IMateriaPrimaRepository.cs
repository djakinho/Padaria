using Padaria.Domain.Model;

namespace Padaria.Data.Interface
{
    public interface IMateriaPrimaRepository : IBaseRepository<MateriaPrima>
    {
        Usuario SelecionarPorNomeESenha(string nome, string senha);
    }
}
