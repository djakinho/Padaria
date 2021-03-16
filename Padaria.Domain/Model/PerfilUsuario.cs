using System.Collections.Generic;

namespace Padaria.Domain.Model
{
   public class PerfilUsuario : IEntity
    {
        public int Id { get; set; }
        public string Perfil { get; set; }
        public List<Usuario> Usuario { get; set; }
    }
}
