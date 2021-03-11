using Microsoft.EntityFrameworkCore;
using Padaria.Data.Map;
using Padaria.Domain.Model;

namespace Padaria.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Caixa> Caixa { get; set; }

        public Contexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CaixaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
