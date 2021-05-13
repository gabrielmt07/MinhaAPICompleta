﻿using Microsoft.Extensions.DependencyInjection;
using DevIO.Data.Context;
using DevIO.Business.Intefaces;
using DevIO.Business.Notificacoes;
using DevIO.Data.Repository;
using DevIO.Business.Services;
using Microsoft.AspNetCore.Http;
using DevIO.Api.Extensions;

namespace DevIO.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IFornecedorService, FornecedorService>();
            services.AddScoped<IProdutoService, ProdutoService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IUser, AspNetUser>();


            return services;
        }
    }
}
