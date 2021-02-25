using Financeiro.Domain.Interfaces.Service;
using Financeiro.Service.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Financeiro.CrossCutting.DependencyInjection
{
    public class ConfigureService
    {
        public static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IDividaService, DividaService>();
        }
    }
}
