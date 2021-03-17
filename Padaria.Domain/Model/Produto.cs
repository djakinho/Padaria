using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class Produto : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UnidadeMedida { get; set; }
        public TipoProducao TipoProducao { get; set; }
        public bool Ativo { get; set; }
        public Receita MateriaisUsados { get; set; }
    }
}
