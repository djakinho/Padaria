using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class ReceitaMap : IEntityTypeConfiguration<Receita>
    {
        public void Configure(EntityTypeBuilder<Receita> builder)
        {
            builder.ToTable("Receita");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(50)")
                .IsRequired();

            builder.Property(x => x.ModoPreparo)
                .HasColumnType("varchar(MAX)")
                .IsRequired();

            builder.HasOne(x => x.Produto)
                .WithOne(x => x.Receita)
                .HasForeignKey<Produto>(x => x.IdReceita);
        }
    }
}
