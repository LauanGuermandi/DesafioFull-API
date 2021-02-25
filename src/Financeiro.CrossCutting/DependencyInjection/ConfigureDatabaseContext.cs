using System;
using Financeiro.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Financeiro.CrossCutting.DependencyInjection
{
  public class ConfigureDatabaseContext
  {
    public static void Configure(IServiceCollection serviceCollection)
    {
      if (Environment.GetEnvironmentVariable("DATABASE").ToLower() == "mysql")
      {
        serviceCollection.AddDbContext<DatabaseContext>(
          options => options.UseMySql(Environment.GetEnvironmentVariable("DB_CONNECTION"))
        );
      }
    }
  }
}
