using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class MateriaPrimaMap : IEntityTypeConfiguration<MateriaPrima>
    {
        public void Configure(EntityTypeBuilder<MateriaPrima> builder)
        {
            builder.ToTable("MateriaPrima");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Ativo)
                .IsRequired();

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnType("float(24)")
                .IsRequired();

            builder.HasOne(x => x.Produto)
                .WithOne(x => x.MateriaPrima)
                .HasForeignKey<Produto>(x => x.IdMateriaPrima);

            builder.HasOne(x => x.EstoqueProduto)
                .WithOne(x => x.MateriaPrima)
                .HasForeignKey<EstoqueProduto>(x => x.IdMateriaPrima);
        }
    }
}