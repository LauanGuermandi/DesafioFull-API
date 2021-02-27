using System.Collections.Generic;

namespace Financeiro.Domain.Entities
{
    public class Pessoa : BaseEntity
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public virtual List<Divida> Dividas { get; private set; }
    }
}
