using System.Collections.Generic;

namespace Financeiro.Domain.Entidades
{
    public class Pessoa : EntidadeBase
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public List<Divida> Dividas { get; private set; }
    }
}
