using System.Threading.Tasks;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Repository
{
    public class PessoaRepository : BaseRepository<Pessoa>, IPessoaRepository
    {
        private readonly DbSet<Pessoa> _dataset;

        public PessoaRepository(DataContext context) : base(context)
        {
            this._dataset = context.Set<Pessoa>();
        }

        public Task<bool> ExistAsync(string cpf)
        {
            throw new System.NotImplementedException();
        }
    }
}
