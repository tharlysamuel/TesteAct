using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAct.Domain;
using TesteAct.Infra.Data.Config;

namespace TesteAct.Infra.Data.Context
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options) : base(options)
        {
        }

        public DbSet<Acoes> Acoes { get; set; }
        public DbSet<RegistroOperacoes> RegistroOperacoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var serverVersion = ServerVersion.AutoDetect("Server=localhost;Port=3306;Database=TesteAct;Uid=root;Pwd=1234;");


                optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=TesteAct;Uid=root;Pwd=1234;", serverVersion);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Acoes>(new AcoesConfig().Configure);
            modelBuilder.Entity<RegistroOperacoes>(new RegistroOperacoesConfig().Configure);

        }
    }
}
