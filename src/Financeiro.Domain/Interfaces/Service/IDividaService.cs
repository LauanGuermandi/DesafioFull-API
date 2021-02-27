using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.DividaDtos;

namespace Financeiro.Domain.Interfaces.Service
{
    public interface IDividaService
    {
        Task<DividaResultDto> Get(Guid id);
        Task<IEnumerable<DividaResultDto>> GetByPessoaId(Guid id);
        Task<DividaResultDto> Post(DividaDto divida);
    }
}
