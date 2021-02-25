using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Service
{
    public interface IDividaService
    {
        Task<Divida> Get(Guid id);
        Task<IEnumerable<Divida>> GetAll();
        Task<Divida> Post(Divida user);
        Task<Divida> Put(Divida user);
        Task<bool> Delete(Guid id);
    }
}
