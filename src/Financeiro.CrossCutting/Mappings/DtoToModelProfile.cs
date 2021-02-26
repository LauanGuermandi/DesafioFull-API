using AutoMapper;
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
        }
    }
}
