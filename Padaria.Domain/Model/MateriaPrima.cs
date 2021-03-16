using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class MateriaPrima : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }
        public int IdUnidadeMedida { get; set; }
        public double Quantidade { get; set; }
        public bool Ativo { get; set; }
        public List<MateriaPrimaReceita> MateriaPrimaReceita { get; set; }
    }
}
