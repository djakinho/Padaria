namespace Padaria.Domain.Model
{
    public class TipoPagamento : IEntity
    {
        public int Id { get; set; }
        public string PagamentoTipo { get; set; }
        public RealizarVenda RealizarVenda { get; set; }
        public int IdRealizarVenda { get; set; }
    }

}
