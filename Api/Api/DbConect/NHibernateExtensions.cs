using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using NHibernate.Cfg;
using NHibernate.Cfg.MappingSchema;
using NHibernate.Connection;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Mapping.ByCode;
using System.IO;
using System.Reflection;

namespace Api.DbConect
{
    public static class NHibernateExtensions
    {
        public static IServiceCollection AddNHibernate(this IServiceCollection services, string connectionString)
        {
            var mapper = new ModelMapper();
            mapper.AddMappings(typeof(NHibernateExtensions).Assembly.ExportedTypes);
            HbmMapping domainMapping = mapper.CompileMappingForAllExplicitlyAddedEntities();

            var configuration = new Configuration();
            configuration.DataBaseIntegration(config =>
            {
                config.ConnectionProvider<DriverConnectionProvider>();
                config.Dialect<PostgreSQL83Dialect>();
                config.Timeout = 60;
                config.ConnectionString = connectionString;
                config.KeywordsAutoImport = Hbm2DDLKeyWords.AutoQuote;
                config.SchemaAction = SchemaAutoAction.Validate;
                config.LogFormattedSql = true;
                config.LogSqlInConsole = true;
                config.Driver<NpgsqlDriver>();
                config.SchemaAction = SchemaAutoAction.Update;
                //config.SchemaAction = SchemaAutoAction.Recreate; //si hay algun cambio recrea la base de datos, siempre la recrea y inserta

            });
            configuration.AddMapping(domainMapping);

            var sessionFactory = configuration.BuildSessionFactory();

            //string[] resourceNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();
            //Console.WriteLine(resourceNames); //para obtener el nombre del recurso porque le cambie l nombre al proyecto varias veces


            services.AddSingleton(sessionFactory);
            services.AddScoped(factory => sessionFactory.OpenSession());


            //Servicios vinculados a las entidades
            //services.AddScoped<SocioDAO>();
          

            return services;
        }
    }
}

