using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.ParcelaDtos;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Service
{
    public interface IParcelaService
    {
        Task<IEnumerable<ParcelaDto>> GetAll();
        Task<ParcelaCreateDto> Post(ParcelaCreateDto parcela);
    }
}
