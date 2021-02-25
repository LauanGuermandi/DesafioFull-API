using System;
using Financeiro.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Financeiro.CrossCutting.DependencyInjection
{
    public class ConfigureDatabaseContext
    {
        public static void Configure(IServiceCollection serviceCollection)
        {
            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new DatabaseConnectionException("Variavel de ambiente 'CONNECTION_STRING' não está configurada.");
            }

            serviceCollection.AddDbContext<DataContext>(
                options => options.UseMySql(connectionString)
            );
        }
    }
}
