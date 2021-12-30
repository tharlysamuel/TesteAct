using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace TesteAct.Infra.Data.Context
{
    public class BaseContextFactory :  IDesignTimeDbContextFactory<BaseContext>
    {
        public BaseContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<BaseContext>();

            var serverVersion = ServerVersion.AutoDetect("Server=localhost;Port=3306;Database=TesteAct;Uid=root;Pwd=1234;");

            optionsBuilder.UseMySql("Server=localhost;Port=3306;Database=TesteAct;Uid=root;Pwd=1234;", serverVersion);
        return new BaseContext(optionsBuilder.Options);

    }
}
}
