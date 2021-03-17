using Minha1Conexao.Data.Repository;
using Padaria.Data.Interface;
using Padaria.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace Padaria.Data.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(Contexto contexto) : base(contexto)
        {

        }
        public List<Usuario> SelectPorNome(string nome)
        {
            var users = SelecionarTudo()
                .Where(x => x.Nome.Contains(nome))
                .OrderBy(x => x.Nome)
                .ToList();
            return users;
        }

        public List<Usuario> SelectPorEmail(string email)
        {
            var users = SelecionarTudo()
                .Where(x => x.Email.Contains(email))
                .OrderBy(x => x.Nome)
                .ToList();
            return users;
        }

        public override List<Usuario> SelecionarTudo()
        {
            var usuarios = _contexto.Set<Usuario>()
                .Join
                (
                    _contexto.Set<PerfilUsuario>(),
                    u => u.Perfil.Id,
                    p => p.Id,
                    (u, p) => new Usuario()
                    {
                        Id = u.Id, 
                        Nome = u.Nome,
                        Email = u.Email,
                        Senha = u.Senha,
                        DataNasc = u.DataNasc,
                        CPF = u.CPF,
                        Perfil = p
                    }
                )
                .ToList();
            usuarios.OrderBy(u => u.Nome);
            return usuarios;
        }
        public Usuario SelecionarPorNomeESenha(string nome, string senha)
        {
            return SelecionarTudo().Where(u => u.Nome == nome && u.Senha == senha).FirstOrDefault();
        }

        public override Usuario Selecionar(int id)
        {
            return SelecionarTudo().FirstOrDefault(x => x.Id == id);
        }
    }
}
