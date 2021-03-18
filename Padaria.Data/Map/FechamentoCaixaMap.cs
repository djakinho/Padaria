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
        }
    }
}
