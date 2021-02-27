using System.Data;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Domain.Entities
{
    public class Parametro : BaseEntity
    {
        public string Chave { get; set; }
        public string Valor { get; set; }
    }
}
