using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.ParcelaDtos;
using Financeiro.Domain.Interfaces.Service;

namespace Financeiro.Service.Services
{
    public class ParcelaService : IParcelaService
    {
        public Task<IEnumerable<ParcelaDto>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ParcelaCreateDto> Post(ParcelaCreateDto parcela)
        {
            throw new System.NotImplementedException();
        }
    }
}
