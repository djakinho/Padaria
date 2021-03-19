using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class RealizarVendaMap : IEntityTypeConfiguration<RealizarVenda>
    {
        public void Configure(EntityTypeBuilder<RealizarVenda> builder)
        {
            builder.ToTable("RealizarVenda");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataVenda)
                .HasColumnType("datetime2(7)")
                .IsRequired();

            builder.Property(x => x.ValorTotal)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.HasOne(x => x.Pagamento)
                .WithOne(x => x.RealizarVenda)
                .HasForeignKey<TipoPagamento>(x => x.IdRealizarVenda);

            builder.HasOne(x => x.Funcionario)
                .WithOne(x => x.RealizarVenda)
                .HasForeignKey<Usuario>(x => x.IdRealizarVenda);
        }
    }
}
