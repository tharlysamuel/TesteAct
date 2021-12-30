using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAct.Domain;

namespace TesteAct.Infra.Data.Config
{
    public class RegistroOperacoesConfig : IEntityTypeConfiguration<RegistroOperacoes>
    {
        public void Configure(EntityTypeBuilder<RegistroOperacoes> builder)
        {
            {
                builder.HasKey(u => u.Id);
                builder.Property(u => u.CodigoAcao).HasMaxLength(10).IsRequired();
                builder.Property(u => u.TipoOperacao).HasMaxLength(1).IsRequired();
                builder.Property(u => u.DataOperacao).IsRequired();
                builder.Property(u => u.Quantidade).IsRequired();
                builder.Property(u => u.ValorAcao).IsRequired();
                builder.Property(u => u.ValorTotal).IsRequired();


                builder.HasOne(u => u.Acoes).WithMany(e => e.RegistroOperacoes).HasForeignKey(u => u.CodigoAcao).OnDelete(DeleteBehavior.ClientSetNull);
            }
        }
    }
}
