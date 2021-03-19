using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class FechamentoCaixaMap : IEntityTypeConfiguration<FechamentoCaixa>
    {
        public void Configure(EntityTypeBuilder<FechamentoCaixa> builder)
        {
            builder.ToTable("FechamentoCaixa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataAbertura)
                .HasColumnType("datetime2(7)")
                .IsRequired();

            builder.Property(x => x.DataFechamento)
                .HasColumnType("datetime2(7)")
                .IsRequired();

            builder.Property(x => x.SituacaoCaixa)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.HasOne(x => x.Usuario)
                .WithOne(x => x.FechamentoCaixa)
                .HasForeignKey<Usuario>(x => x.IdFechamentoCaixa);

        }
    }
}
