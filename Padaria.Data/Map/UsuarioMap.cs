﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(i => i.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.CPF)
               .HasColumnType("varchar(14)")
               .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Senha)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.DataNasc)
               .HasColumnType("datetime")
               .IsRequired();
        }
    }
}
