using System;
namespace Financeiro.Domain.Dtos.ParcelaDtos
{
    public class ParcelaCreateDto
    {
        public Guid DividaId { get; set; }
        public int Numero { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
    }
}

