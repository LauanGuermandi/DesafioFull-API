using System;
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
        public Task<IEnumerable<Divida>> GetDividasByPessoaId(Guid pessoaId)
        {
            throw new NotImplementedException();
        }
    }
}
