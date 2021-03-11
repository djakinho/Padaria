using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class FornecedorMap : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedor");

            builder.HasKey(i => i.Id);

            builder.Property(x => x.Cnpj)
                .HasColumnType("varchar(14)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(150")
                .IsRequired();

            builder.Property(x => x.InscricaoEstatual)
                .HasColumnType("varchar(9")
                .IsRequired();

            builder.Property(x => x.RazaoSocial)
                .HasColumnType("varchar(150")
                .IsRequired();

            builder.Property(x => x.Site)
                .HasColumnType("varchar(200")
                .IsRequired();

            builder.Property(x => x.Telefone)
                .HasColumnType("varchar(200");

        }
    }
}
