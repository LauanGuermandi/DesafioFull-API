using System;

namespace Financeiro.Domain.Dtos.DividaDtos
{
    public class DividaResultDto
    {
        public Guid Id { get; set; }
        public Guid PessoaId { get; set; }

        public decimal PorcentagemJuros { get; set; }
        public decimal PorcentagemMulta { get; set; }

        public string NumeroTitulo { get; set; }
        public double ValorOriginal { get; set; }
        public int DiasAtraso { get; set; }
        public double ValorAtualizado { get; set; }
        public int QuantidadeParcelas { get; set; }
    }
}
