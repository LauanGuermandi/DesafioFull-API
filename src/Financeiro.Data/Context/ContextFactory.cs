using System;
using Financeiro.Domain.Exceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Financeiro.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");
            if (String.IsNullOrEmpty(connectionString))
            {
                throw new DatabaseConnectionException("Variavel de ambiente 'CONNECTION_STRING' não está configurada.");
            }

            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
            optionsBuilder.UseMySql(connectionString);
            return new DataContext(optionsBuilder.Options);
        }
    }
}
