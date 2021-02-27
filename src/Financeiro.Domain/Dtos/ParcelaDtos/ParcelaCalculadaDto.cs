using System;

namespace Financeiro.Domain.Dtos.ParcelaDtos
{
    public class ParcelaCalculadaDto
    {
        public int Numero { get; set; }
        public DateTime DataVencimento { get; set; }
        public double ValorOriginal { get; set; }
        public double ValorAtualizado { get; set; }
        public int DiasAtrasado { get; set; }
        public double Juros { get; set; }
    }
}
