using System;
using System.Collections.Generic;
using System.Text;
using Padaria.Domain;

namespace Padaria.Domain.Model
{
    public class Usuario : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNasc { get; set; }
        public string CPF { get; set; }
        public PerfilUsuario Perfil { get; set; }
        public int IdPerfilUsuario { get; set; }
    }
}
