using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class MateriaPrimaReceitaMap : IEntityTypeConfiguration<MateriaPrimaReceita>
    {
        public void Configure(EntityTypeBuilder<MateriaPrimaReceita> builder)
        {
            builder.ToTable("MateriaPrimaReceita");

            builder.HasKey(x => new { x.IdMateriaPrima, x.IdReceita });

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.HasOne(x => x.Receita)
                .WithMany(x => x.MateriaPrimaReceita)
                .HasForeignKey(x => x.IdReceita)
                .IsRequired();

            builder.HasOne(x => x.MateriaPrima)
                .WithMany(x => x.MateriaPrimaReceita)
                .HasForeignKey(x => x.IdMateriaPrima)
                .IsRequired();
        }
    }
}