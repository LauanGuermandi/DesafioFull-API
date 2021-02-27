using AutoMapper;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Models;

namespace Financeiro.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            // PESSOA
            CreateMap<PessoaModel, Pessoa>()
               .ReverseMap();

            // DIVIDA
            CreateMap<DividaModel, Divida>()
                .ReverseMap();

            // PARCELA
            CreateMap<ParcelaModel, Parcela>()
                .ReverseMap();
        }
    }
}
