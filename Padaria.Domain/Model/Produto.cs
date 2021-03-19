using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class Produto : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UnidadeMedida { get; set; }
        public TipoProducao TipoProducao { get; set; }
        public int IdTipoProducao { get; set; }
        public bool Ativo { get; set; }
        public Receita Receita { get; set; }
        public int IdReceita { get; set; }
        public EstoqueProduto EstoqueProduto { get; set; }
        public int IdEstoqueProduto { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int IdMateriaPrima { get; set; }
        public List<MateriaPrimaProduto> MateriaPrimaProduto { get; set; }
       
    }
}
