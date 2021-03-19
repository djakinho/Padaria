using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class RealizarVendaProdutoMap : IEntityTypeConfiguration<RealizarVendaProduto>
    {
        public void Configure(EntityTypeBuilder<RealizarVendaProduto> builder)
        {
            builder.ToTable("RealizarVendaProduto");

            builder.HasKey(x => new { x.IdRealizarVenda, x.IdProduto });

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.HasOne(x => x.RealizarVenda)
                .WithMany(x => x.RealizarVendaProduto)
                .HasForeignKey(x => x.RealizarVenda)
                .IsRequired();

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.RealizarVendaProduto)
                .HasForeignKey(x => x.IdProduto)
                .IsRequired();
        }
    }
}