using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Interface
{
    public interface IUsuarioRepository : IBaseRepository<Usuario>
    {
        List<Usuario> SelectPorNome(string nome);
        List<Usuario> SelectPorEmail(string email);
        List<Usuario> SelecionarTudo();
        Usuario SelecionarPorNomeESenha(string nome, string senha);
    }
}
