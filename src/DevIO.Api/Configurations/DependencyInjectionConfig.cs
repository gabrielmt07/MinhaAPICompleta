﻿using Microsoft.Extensions.DependencyInjection;
using DevIO.Data.Context;
using DevIO.Business.Intefaces;
using DevIO.Data.Repository;

namespace DevIO.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();

            return services;
        }
    }
}
