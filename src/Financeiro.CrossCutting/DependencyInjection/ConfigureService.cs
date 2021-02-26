using AutoMapper;
using Financeiro.CrossCutting.Mappings;
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
            serviceCollection.AddTransient<IPessoaService, PessoaService>();

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new EntityToDtoProfile());
                mc.AddProfile(new ModelToEntityProfile());
                mc.AddProfile(new DtoToModelProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            serviceCollection.AddSingleton(mapper);
        }
    }
}
