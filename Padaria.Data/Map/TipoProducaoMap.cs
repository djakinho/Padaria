using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

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

            builder.HasMany<Produto>(x => x.Produtos)
                .WithOne(x => x.TipoProducao)
                .HasForeignKey(x => x.IdTipoProducao)
                .IsRequired();
        }
    }
}
