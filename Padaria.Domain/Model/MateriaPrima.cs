using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Domain.Model
{
    public class MateriaPrima : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
        public List<MateriaPrimaProduto> MateriaPrimaProduto { get; set; }
        public List<MateriaPrimaReceita> MateriaPrimasReceita { get; set; }
    }
}
