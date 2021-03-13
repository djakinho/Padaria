using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class UnidadeMedida : IEntity
    {
        public int Id { get; set; }
        public string Unidade { get; set; }
    }
}
