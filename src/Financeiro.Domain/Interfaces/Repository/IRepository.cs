using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> InsertAsync(TEntity item);
        Task<TEntity> SelectAsync(Guid id);
        Task<IEnumerable<TEntity>> SelectAsync();
    }
}
