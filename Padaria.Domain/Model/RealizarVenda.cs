﻿using System;
using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class RealizarVenda : IEntity
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal ValorTotal { get; set; }
        public TipoPagamento Pagamento { get; set; }
        public Usuario Funcionario { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
