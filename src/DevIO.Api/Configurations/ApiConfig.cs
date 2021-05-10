using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.Api.Configurations
{
    public static class ApiConfig
    {
        public static IServiceCollection WebApiConfig(this IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.Configure<ApiBehaviorOptions>(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            });

            IdentityModelEventSource.ShowPII = true;
            var policy = new Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicyBuilder()
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .Build();

            services.AddCors(x => x.AddPolicy("GlobalCors", policy));

            return services;
        }
    }
}
