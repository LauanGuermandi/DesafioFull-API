using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Data.Context;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Repository
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DataContext _context;

        private DbSet<TEntity> _dataset;

        public BaseRepository(DataContext context)
        {
            this._context = context;
            this._dataset = _context.Set<TEntity>();
        }

        public async Task<TEntity> InsertAsync(TEntity item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                item.DataCriacao = DateTime.UtcNow;
                _dataset.Add(item);

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return item;
        }

        public async Task<TEntity> SelectAsync(Guid id)
        {
            try
            {
                var result = await _dataset.SingleOrDefaultAsync(p => p.Id.Equals(id));

                if (result == null)
                {
                    return null;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<TEntity>> SelectAsync()
        {
            return await _dataset.ToListAsync();
        }
    }
}
