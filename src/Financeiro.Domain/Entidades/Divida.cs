using System;
using System.Collections.Generic;

namespace Financeiro.Domain.Entidades
{
    public class Divida : EntidadeBase
    {
        public double ValorOriginal { get; private set; }
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public List<Parcela> Parcelas { get; private set; }
    }
}
