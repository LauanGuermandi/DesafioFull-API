using System;
using System.Collections.Generic;

namespace Financeiro.Domain.Entities
{
    public class Divida : BaseEntity
    {
        public double ValorOriginal { get; private set; }
        public string NumeroTitulo { get; set; }
        public int PorcentagemJuros { get; set; }
        public int PorcentagemMulta { get; set; }
        public Guid PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public virtual List<Parcela> Parcelas { get; private set; }
    }
}
