using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class TipoProducao : IEntity
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
