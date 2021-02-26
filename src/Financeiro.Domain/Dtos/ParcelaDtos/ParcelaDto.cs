using System;

namespace Financeiro.Domain.Dtos.ParcelaDtos
{
    public class ParcelaDto
    {
        public int Numero { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
    }
}
