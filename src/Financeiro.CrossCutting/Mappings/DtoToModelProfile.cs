using System;
using AutoMapper;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Dtos.ParcelaDtos;
using Financeiro.Domain.Dtos.PessoaDtos;
using Financeiro.Domain.Models;

namespace Financeiro.CrossCutting.Mappings
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            // PESSOA
            CreateMap<PessoaCreateDto, PessoaModel>()
                .ReverseMap();

            // DIVIDA
            CreateMap<DividaDto, DividaModel>()
                .ReverseMap();
            
            // PARCELA
            CreateMap<ParcelaDto, ParcelaModel>()
                .ReverseMap();
        }
    }
}
