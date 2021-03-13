using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class Receita : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ModoPreparo { get; set; }
        public List<MateriaPrima> Ingredientes { get; set; }
    }
}
