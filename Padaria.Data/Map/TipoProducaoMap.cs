using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class TipoProducaoMap : IEntityTypeConfiguration<TipoProducao>
    {
        public void Configure(EntityTypeBuilder<TipoProducao> builder)
        {
            builder.ToTable("TipoProducao");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Tipo)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.HasOne(x => x.EstoqueProduto)
                .WithOne(x => x.TipoProducao)
                .HasForeignKey<EstoqueProduto>(x => x.IdTipoProducao)
                .IsRequired();
        }
    }
}
