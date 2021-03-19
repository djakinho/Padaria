using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class Receita : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ModoPreparo { get; set; }
        public ProdutoEmProducao ProdutoEmProducao { get; set; }
        public int IdProdutoEmProducao { get; set; }
        public Produto Produto { get; set; }
        public List<MateriaPrimaReceita> MateriaPrimaReceita { get; set; }
    }
}
