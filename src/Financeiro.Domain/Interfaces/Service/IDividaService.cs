using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Service
{
    public interface IDividaService
    {
        Task<DividaCalculadaDto> Get(Guid id);
        Task<IEnumerable<DividaCalculadaDto>> GetAll();
        Task<DividaDto> Post(DividaDto divida);
    }
}
