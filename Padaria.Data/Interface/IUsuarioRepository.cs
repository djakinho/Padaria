using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario SelectPorNome(string nome);
        Usuario SelectPorEmail(string email);
        List<Usuario> SelectTodos();
    }
}
