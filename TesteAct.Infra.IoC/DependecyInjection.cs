using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using TesteAct.Domain;
using TesteAct.Domain.Interfaces.Repository;
using TesteAct.Domain.Interfaces.Services;
using TesteAct.Infra.Data.Repository;
using TesteAct.Service;

namespace TesteAct.Infra.IoC
{
    public class DependecyInjection
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IAcoesService, AcoesService>();
            services.AddScoped<IRegistroOperacoesService, RegistroOperacoesService>();

            services.AddScoped<IAcoesRepository, AcoesRepository>();
            services.AddScoped<IRegistroOperacoesRepository, RegistroOperacoesRepository>();
        }
    }
}
