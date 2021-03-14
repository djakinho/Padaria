namespace Padaria.Domain.Model
{
    public class MateriaPrimaProduto : IEntity
    {
        public int Id { get; set; }
        public int IdMateriaPrima { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }

    }
}
