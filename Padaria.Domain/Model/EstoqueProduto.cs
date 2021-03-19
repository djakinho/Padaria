namespace Padaria.Domain.Model
{
    public class EstoqueProduto : IEntity
    {
        public int Id { get; set; }
        public double Preco { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
        public TipoProducao TipoProducao { get; set; }
        public int IdTipoProducao { get; set; }
        public Produto Produto { get; set; }
        public int IdProduto { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int IdMateriaPrima { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int IdUnidadeMedida { get; set; }

    }
}
