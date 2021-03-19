namespace Padaria.Domain.Model
{
    public class ProdutoEmProducao :IEntity
    {
        public int Id { get; set; }
        public double Quantidade { get; set; }
        public Receita Receita { get; set; }
        public int IdReceita { get; set; }

    }
}
