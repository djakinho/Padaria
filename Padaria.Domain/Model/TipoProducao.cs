namespace Padaria.Domain.Model
{
    public class TipoProducao : IEntity
    {
        public int Id { get; set; }
        public string Tipo{ get; set; }
        public EstoqueProduto EstoqueProduto { get; set; }
        public int IdEstoqueProduto { get; set; }
    }
}
