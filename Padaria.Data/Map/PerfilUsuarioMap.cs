using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Padaria.Domain.Model;

namespace Padaria.Data.Map
{
    public class PerfilUsuarioMap : IEntityTypeConfiguration<PerfilUsuario>
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
