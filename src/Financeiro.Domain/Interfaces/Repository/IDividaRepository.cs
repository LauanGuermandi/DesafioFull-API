using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Repository
{
    public interface IDividaRepository : IRepository<Divida>
    {
        Task<IEnumerable<Divida>> GetDividasByPessoaId(Guid pessoaId);
        Task<Divida> GetDividaCalculada(Guid id);
    }
}
