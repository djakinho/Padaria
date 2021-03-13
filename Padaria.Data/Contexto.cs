using Microsoft.EntityFrameworkCore;
using Padaria.Data.Map;
using Padaria.Domain.Model;

namespace Padaria.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<PerfilUsuario> Perfil { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public DbSet<TipoProducao> TipoProducao { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CaixaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilUsuarioMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new UnidadeMedidaMap());
            modelBuilder.ApplyConfiguration(new TipoProducaoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
