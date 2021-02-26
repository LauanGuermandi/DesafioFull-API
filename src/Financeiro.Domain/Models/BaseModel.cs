using System;

namespace Financeiro.Domain.Models
{
    public class BaseModel
    {
        private Guid _id;
        public Guid Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private DateTime _dataCriacao;
        public DateTime DataCriacao
        {
            get { return _dataCriacao; }
            set
            {
                _dataCriacao = value == null ? DateTime.UtcNow : value;
            }
        }

        private DateTime _dataAtualizacao;
        public DateTime DataAtualizacao
        {
            get { return _dataAtualizacao; }
            set { _dataAtualizacao = value; }
        }
    }
}
