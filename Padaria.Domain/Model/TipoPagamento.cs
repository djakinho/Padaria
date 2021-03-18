namespace Padaria.Domain.Model
{
    public class TipoPagamento : IEntity
    {
        public int Id { get; set; }
        public string PagamentoTipo { get; set; }
    }

}
