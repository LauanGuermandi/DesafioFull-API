using Financeiro.Data.Implementations;
using Financeiro.Data.Repository;
using Financeiro.Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Financeiro.CrossCutting.DependencyInjection
{
    public class ConfigureRepository
    {
        public static void Configure(IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            serviceCollection.AddScoped<IPessoaRepository, PessoaImplementation>();
        }
    }
}
