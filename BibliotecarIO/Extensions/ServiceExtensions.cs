using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibliotecarIO.DataBase;
using BibliotecarIO.Models.Intefaces;
using BibliotecarIO.Repository;
using Microsoft.EntityFrameworkCore;

namespace BibliotecarIO.Extensions
{
    public static class ServiceExtensions
    {
        //Habilita a comunicação entre servidores diferentes.
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", builder => builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
            });
        }

        public static void ConfigureIISIntegration(this IServiceCollection services)
        {
            services.Configure<IISOptions>(options =>
            {
                //As configurações padrões já são suficientes para o funcionamento correto...
            });
        }

        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:MyContext"];
            services.AddDbContext<BibliotecarioContext>(c => c.UseSqlServer(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}