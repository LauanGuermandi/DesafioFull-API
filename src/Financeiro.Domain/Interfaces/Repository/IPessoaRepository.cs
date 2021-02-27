using System.Threading.Tasks;
using Financeiro.Domain.Entities;

namespace Financeiro.Domain.Interfaces.Repository
{
    public interface IPessoaRepository : IRepository<Pessoa>
    {
        Task<bool> ExistAsync(string cpf);
    }
}
