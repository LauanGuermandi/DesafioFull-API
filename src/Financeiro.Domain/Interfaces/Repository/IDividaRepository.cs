using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Repository
{
    public interface IDividaRepository
    {
        Task<IEnumerable<Divida>> GetDividas(Guid pessoaId);
    }
}
