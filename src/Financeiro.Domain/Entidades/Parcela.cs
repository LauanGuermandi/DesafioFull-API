using System;

namespace Financeiro.Domain.Entidades
{
    public class Parcela : EntidadeBase
    {
        public int Numero { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
        public int DividaId { get; set; }
        public Divida Divida { get; set; }
    }
}
