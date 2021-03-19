using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class MateriaPrima : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int IdUnidadeMedida { get; set; }
        public Produto Produto { get; set; }
        public int IdProduto { get; set; }
        public EstoqueProduto EstoqueProduto { get; set; }
        public int IdEstoqueProduto { get; set; }
        public List<MateriaPrimaReceita> MateriaPrimaReceita { get; set; }
        public List<MateriaPrimaProduto> MateriaPrimaProduto { get; set; }
    }
}
