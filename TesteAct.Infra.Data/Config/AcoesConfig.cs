using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAct.Domain;

namespace TesteAct.Infra.Data.Config
{
    public class AcoesConfig : IEntityTypeConfiguration<Acoes>
    {
        public void Configure(EntityTypeBuilder<Acoes> builder)
        {
            builder.HasKey(u => u.CodigoAcao);
            builder.Property(u => u.CodigoAcao).HasMaxLength(10).IsRequired();
            builder.Property(u => u.RazaoSocial).HasMaxLength(250).IsRequired();
            

            


        }
    }
}
