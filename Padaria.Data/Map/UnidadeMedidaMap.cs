using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class UnidadeMedidaMap : IEntityTypeConfiguration<UnidadeMedida>
    {
        public void Configure(EntityTypeBuilder<UnidadeMedida> builder)
        {
            builder.ToTable("UnidadeMedida");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Unidade)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.HasMany(x => x.MateriaPrima)
                .WithOne(x => x.UnidadeMedida)
                .HasForeignKey(x => x.IdUnidadeMedida)
                .IsRequired();
        }
    }
}
