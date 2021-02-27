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
            serviceCollection.AddTransient<IPessoaService, PessoaService>();
            serviceCollection.AddTransient<IDividaService, DividaService>();

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
