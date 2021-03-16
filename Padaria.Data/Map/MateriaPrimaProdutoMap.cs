using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class MateriaPrimaProdutoMap : IEntityTypeConfiguration<MateriaPrimaProduto>
    {
        public void Configure(EntityTypeBuilder<MateriaPrimaProduto> builder)
        {
            builder.ToTable("MateriaPrimaProduto");

            builder.HasKey(x => new { x.IdMateriaPrima, x.IdProduto });

            builder.HasOne(x => x.MateriaPrima)
                .WithMany(x => x.MateriaPrimaProduto)
                .HasForeignKey(x => x.IdMateriaPrima);

            builder.HasOne(x => x.Produto)
                .WithMany(x => x.MateriaPrimaProduto)
                .HasForeignKey(x => x.IdProduto);

            builder.Property(x => x.Id)
                .UseIdentityColumn();

        }
    }
}
