using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class EstoqueProduto : IEntity
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
        public TipoProducao TipoProducao { get; set; }
        public Produto IdProduto { get; set; }
        public MateriaPrima IdMateriaPrima { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }


    }
}
