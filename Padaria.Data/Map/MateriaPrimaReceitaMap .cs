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

            builder.HasOne(x => x.MateriaPrima)
                .WithMany(x => x.MateriaPrimasReceita)
                .HasForeignKey(x => x.MateriaPrima);

            builder.HasOne(x => x.Receita)
                .WithMany(x => x.MateriaPrimaReceita)
                .HasForeignKey(x => x.Receita);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

        }
    }
}