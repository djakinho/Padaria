using Microsoft.EntityFrameworkCore;
using Padaria.Data.Map;
using Padaria.Domain.Model;

namespace Padaria.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Caixa> Caixa { get; set; }
        public DbSet<EstoqueProduto> EstoqueProduto { get; set; }
        public DbSet<FechamentoCaixa> FechamentoCaixa { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<MateriaPrima> MateriaPrima { get; set; }
        public DbSet<MateriaPrimaProduto> MateriaPrimaProduto { get; set; }
        public DbSet<MateriaPrimaReceita> MateriaPrimaReceita { get; set; }
        public DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public DbSet<PerfilUsuario> Perfil { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<RealizarVenda> RealizarVenda { get; set; }
        public DbSet<Receita> Receita { get; set; }
        public DbSet<TipoPagamento> TipoPagamento { get; set; }
        public DbSet<TipoProducao> TipoProducao { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedida { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CaixaMap());
            modelBuilder.ApplyConfiguration(new EstoqueProdutoMap());
            modelBuilder.ApplyConfiguration(new FechamentoCaixaMap());
            modelBuilder.ApplyConfiguration(new FornecedorMap());
            modelBuilder.ApplyConfiguration(new MateriaPrimaMap());
            modelBuilder.ApplyConfiguration(new MateriaPrimaProdutoMap());
            modelBuilder.ApplyConfiguration(new MateriaPrimaReceitaMap());
            modelBuilder.ApplyConfiguration(new PerfilUsuarioMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new RealizarVendaMap());
            modelBuilder.ApplyConfiguration(new ReceitaMap());
            modelBuilder.ApplyConfiguration(new TipoPagamentoMap());
            modelBuilder.ApplyConfiguration(new TipoProducaoMap());
            modelBuilder.ApplyConfiguration(new UnidadeMedidaMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
