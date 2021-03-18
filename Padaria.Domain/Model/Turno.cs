using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class Turno : IEntity
    {
        public int Id { get; set; }
        public string TurnoPeriodo { get; set; }
    }
}
