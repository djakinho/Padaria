using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class ProdutoEmProducaoMap : IEntityTypeConfiguration<ProdutoEmProducao>
    {
        public void Configure(EntityTypeBuilder<ProdutoEmProducao> builder)
        {
            builder.ToTable("ProdutoEmProducao");

            builder.HasKey(i => i.Id);

            builder.Property(x => x.Quantidade)
                .HasColumnType("varchar(20)")
                .IsRequired();

            builder.HasOne(x => x.Receita)
                .WithOne(x => x.ProdutoEmProducao)
                .HasForeignKey<Receita>(x => x.IdProdutoEmProducao);

        }
    }
}
