using System;

namespace Padaria.Domain.Model
{
    public class FechamentoCaixa : IEntity
    {
        public int Id { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime DataFechamento { get; set; }
        public bool SituacaoCaixa { get; set; }
        public Usuario Usuario { get; set; }
        public int IdUsuario { get; set; }
    }
}
