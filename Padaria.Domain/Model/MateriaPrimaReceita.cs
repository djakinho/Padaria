namespace Padaria.Domain.Model
{
    public class MateriaPrimaReceita : IEntity
    {
        public int Id { get; set; }
        public int IdMateriaPrima { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int IdReceita { get; set; }
        public Receita Receita { get; set; }
    }
}