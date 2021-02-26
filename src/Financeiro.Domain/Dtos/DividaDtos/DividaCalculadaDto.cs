using System;

namespace Financeiro.Domain.Dtos.DividaDtos
{
    public class DividaCalculadaDto
    {
        public Guid Id { get; set; }
        public string NomePessoa { get; set; }
        public string CPFPessoa { get; set; }

        public decimal PorcentagemJuros { get; set; }
        public decimal PorcentagemMulta { get; set; }

        public long Numero { get; set; }
        public double ValorOriginal { get; set; }
        public int DiasAtraso { get; set; }
        public double ValorAtualizado { get; set; }
        public int QuantidadeParcelas { get; set; }
    }
}
