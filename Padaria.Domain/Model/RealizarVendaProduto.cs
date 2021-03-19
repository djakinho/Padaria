using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class RealizarVendaProduto :IEntity
    {
        public int Id { get; set; }
        public int IdRealizarVenda { get; set; }
        public RealizarVenda RealizarVenda { get; set; }
        public int IdProduto { get; set; }
        public Produto Produto { get; set; }
    }
}
