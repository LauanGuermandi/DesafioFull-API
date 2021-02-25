using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financeiro.Data.Repository;
using Financeiro.Domain.Entities;
using Financeiro.Domain.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Financeiro.Data.Implementation
{
    public class PessoaImplementation : BaseRepository<Divida>, IPessoaRepository
    {
        private DbSet<Pessoa> _dataset;

        public PessoaImplementation(DataContext context) : base(context)
        {
            this._dataset = context.Set<Pessoa>();
        }

        public IEnumerable<Pessoa> GetPessoaWithDivida(Guid PessoaId)
        {
            return _context.Pessoas.Include(
                pessoa => pessoa.Dividas
                    .Where(divida => divida.PessoaId.Equals(PessoaId))
                    .ToList()
            );
        }
    }
}
