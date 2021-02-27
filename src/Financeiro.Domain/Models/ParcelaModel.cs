using System;

namespace Financeiro.Domain.Models
{
    public class ParcelaModel : BaseModel
    {
        private int _numero;
        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private DateTime _dataVencimento;
        public DateTime DataVencimento
        {
            get { return _dataVencimento; }
            set { _dataVencimento = value; }
        }

        private double _valor;
        public double Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
    }
}
