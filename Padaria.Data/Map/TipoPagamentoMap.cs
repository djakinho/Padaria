using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class TipoPagamentoMap : IEntityTypeConfiguration<TipoPagamento>
    {
        public void Configure(EntityTypeBuilder<TipoPagamento> builder)
        {
            builder.ToTable("TipoPagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PagamentoTipo)
                .HasColumnType("varchar(20)")
                .IsRequired();
        }
    }
}
