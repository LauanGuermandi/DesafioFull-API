using System;

namespace Financeiro.Domain.Entities
{
    public class Parcela : BaseEntity
    {
        public int Numero { get; set; }
        public DateTime DataVencimento { get; set; }
        public double Valor { get; set; }
        public Guid DividaId { get; set; }
        public virtual Divida Divida { get; set; }
    }
}
