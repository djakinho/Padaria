using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class RealizarVendaMap : IEntityTypeConfiguration<RealizarVenda>
    {
        public void Configure(EntityTypeBuilder<RealizarVenda> builder)
        {
            builder.ToTable("RealizarVenda");

            builder.HasKey(x => x.Id);
        }
    }
}
