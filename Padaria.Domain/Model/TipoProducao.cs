using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class TipoProducao : IEntity
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
    }
}
