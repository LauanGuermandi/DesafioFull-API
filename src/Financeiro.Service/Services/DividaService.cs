using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Dtos.DividaDtos;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Financeiro.Domain.Interfaces.Service;

namespace Financeiro.Service.Services
{
    public class DividaService : IDividaService
    {
        private IRepository<Divida> _repository;

        public DividaService(IRepository<Divida> repository)
        {
            _repository = repository;
        }

        public Task<DividaCalculadaDto> Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Divida>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<Divida> Post(Divida divida)
        {
            return await _repository.InsertAsync(divida);
        }

        public Task<DividaDto> Post(DividaDto divida)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<DividaCalculadaDto>> IDividaService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
