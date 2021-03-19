using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    public class EstoqueProdutoMap : IEntityTypeConfiguration<EstoqueProduto>
    {
        public void Configure(EntityTypeBuilder<EstoqueProduto> builder)
        {
            builder.ToTable("EstoqueProduto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.TipoProducao)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(x => x.IdProduto)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.Property(x => x.Quantidade)
                .HasColumnType("varchar(30)")
                .IsRequired();

            builder.Property(x => x.UnidadeMedida)
                .HasColumnType("varchar(10)")
                .IsRequired();

            builder.HasOne(x => x.Produto)
                .WithOne(x => x.EstoqueProduto)
                .HasForeignKey<Produto>(x => x.IdEstoqueProduto);

            builder.HasOne(x => x.TipoProducao)
                .WithOne(x => x.EstoqueProduto)
                .HasForeignKey<TipoProducao>(x => x.IdEstoqueProduto);

            builder.HasOne(x => x.MateriaPrima)
                .WithOne(x => x.EstoqueProduto)
                .HasForeignKey<MateriaPrima>(x => x.IdEstoqueProduto);

            builder.HasOne(x => x.UnidadeMedida)
                .WithOne(x => x.EstoqueProduto)
                .HasForeignKey<UnidadeMedida>(x => x.IdEstoqueProduto);

        }
    }
}
