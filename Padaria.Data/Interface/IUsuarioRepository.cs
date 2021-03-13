using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        Usuario SelecionarPorNomeESenha(string nome, string senha);
    }
}
