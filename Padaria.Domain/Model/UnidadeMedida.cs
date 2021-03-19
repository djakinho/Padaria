using System.Collections.Generic;

namespace Padaria.Domain.Model
{
    public class UnidadeMedida : IEntity
    {
        public int Id { get; set; }
        public string Unidade { get; set; }
        public EstoqueProduto EstoqueProduto { get; set; }
        public int IdEstoqueProduto { get; set; }
        public List<MateriaPrima> MateriaPrima { get; set; }
    }
}
