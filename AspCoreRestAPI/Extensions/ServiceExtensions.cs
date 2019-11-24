using AspCoreRestAPI.Contracts;
using AspCoreRestAPI.Entities;
using AspCoreRestAPI.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCoreRestAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
        public static void ConfigureSqliteContext(this IServiceCollection services)
        {
            services.AddDbContext<RepositoryContext>();
        }
    }
}
