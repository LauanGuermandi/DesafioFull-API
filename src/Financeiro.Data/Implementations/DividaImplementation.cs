using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Data.Repository;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Implementations
{
    public class DividaImplementation : BaseRepository<Divida>, IDividaRepository
    {
        private DbSet<Divida> _dataset;
        public DividaImplementation(DataContext context) : base(context)
        {
            _dataset = context.Set<Divida>();
        }

        public async Task<IEnumerable<Divida>> GetDividasByPessoaId(Guid pessoaId)
        {
           return await _dataset.Where(d => d.PessoaId.Equals(pessoaId)).ToListAsync();
        }

        public async Task<Divida> GetDividaCalculada(Guid id) 
        {
            return await _dataset.Include(d => d.Parcelas).Where(d => d.Id.Equals(id)).SingleOrDefaultAsync(); 
        }
    }
}
