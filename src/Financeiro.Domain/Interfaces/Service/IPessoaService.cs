using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.PessoaDtos;

namespace Financeiro.Domain.Interfaces.Service
{
    public interface IPessoaService
    {
        Task<IEnumerable<PessoaDto>> GetAll();
        Task<PessoaDto> Get(Guid Id);
        Task<PessoaDto> Post(PessoaCreateDto pessoa);
        Task<IEnumerable<PessoaDto>> Search(string text);
    }
}
