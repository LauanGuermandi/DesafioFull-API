using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> InsertAsync(TEntity item);
        Task<TEntity> UpdateAsync(TEntity item);
        Task<bool> DeleteAsync(Guid id);
        Task<TEntity> SelectAsync(Guid id);
        Task<IEnumerable<TEntity>> SelectAsync();
        Task<bool> ExistAsync(Guid id);
    }
}
