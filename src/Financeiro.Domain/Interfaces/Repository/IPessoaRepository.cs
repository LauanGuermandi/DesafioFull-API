using System.Threading.Tasks;

namespace Financeiro.Domain.Interfaces.Repository
{
    public interface IPessoaRepository
    {
        Task<bool> ExistAsync(string cpf);
    }
}
