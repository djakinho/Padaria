using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
   public class PerfilUsuario:IEntity
    {
        public int Id { get; set; }
        public string Perfil { get; set; }
    }
}
