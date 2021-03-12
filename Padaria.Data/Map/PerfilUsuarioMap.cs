using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Padaria.Data.Map
{
    class PerfilUsuarioMap
    {
        public class CaixaMap : IEntityTypeConfiguration<PerfilUsuario>
        {
            public void Configure(EntityTypeBuilder<PerfilUsuario> builder)
            {
                builder.ToTable("PerfilUsuario");

                builder.HasKey(i => i.Id);

                builder.Property(x => x.Perfil)
                    .HasColumnType("varchar(100)")
                    .IsRequired();
                    
            }
        }
    }
}
