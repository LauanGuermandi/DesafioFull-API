using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<Divida> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<Divida>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<Divida> Post(Divida user)
        {
            return await _repository.InsertAsync(user);
        }

        public async Task<Divida> Put(Divida user)
        {
            return await _repository.UpdateAsync(user);
        }
    }
}
