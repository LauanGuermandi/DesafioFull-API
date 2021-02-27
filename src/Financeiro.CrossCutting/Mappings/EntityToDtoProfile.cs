using AutoMapper;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Dtos.ParcelaDtos;
using Financeiro.Domain.Dtos.PessoaDtos;
using Financeiro.Domain.Entities;

namespace Financeiro.CrossCutting.Mappings
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            // PESSOA
            CreateMap<PessoaCreateDto, Pessoa>()
                .ReverseMap();
            CreateMap<PessoaDto, Pessoa>()
                .ReverseMap();

            // DIVIDA
            CreateMap<DividaCalculadaDto, Divida>()
                .ReverseMap();
            CreateMap<DividaResultDto, Divida>()
                .ReverseMap();
            CreateMap<DividaDto, Divida>()
                .ReverseMap();

            // PARCELA
            CreateMap<ParcelaCalculadaDto, Parcela>()
                .ForMember(p => p.Valor, o => o.MapFrom(s => s.ValorOriginal))
                .ReverseMap();
        }
    }
}
