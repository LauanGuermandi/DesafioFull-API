using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Data.Repository;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Implementations
{
    public class PessoaImplementation : BaseRepository<Pessoa>, IPessoaRepository
    {
        private DbSet<Pessoa> _dataset;
        public PessoaImplementation(DataContext context) : base(context)
        {
            _dataset = context.Set<Pessoa>();
        }
        public async Task<bool> ExistAsync(string cpf)
        {
            return await _dataset.AnyAsync(p => p.CPF.Equals(cpf));
        }

        public async Task<IEnumerable<Pessoa>> SearchByText(string text) {
            return await _dataset.Where(p => p.Nome.ToLower().Contains(text)).ToListAsync();
        }
    }
}
