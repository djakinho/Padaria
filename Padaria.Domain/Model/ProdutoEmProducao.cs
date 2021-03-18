using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class ProdutoEmProducao :IEntity
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }
        public Receita Receita { get; set; }
        public List<EstoqueMateriaPrima> Estoque { get; set; }
    }
}
