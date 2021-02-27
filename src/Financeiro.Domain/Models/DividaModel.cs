using System;
using System.Collections.Generic;
using Financeiro.Domain.Dtos.ParcelaDtos;

namespace Financeiro.Domain.Models
{
    public class DividaModel : BaseModel
    {
        private Guid _pessoaId;
        public Guid PessoaId
        {
            get { return _pessoaId; }
            set { _pessoaId = value; }
        }

        private string _numeroTitulo;
        public string NumeroTitulo
        {
            get { return _numeroTitulo; }
            set { _numeroTitulo = value; }
        }

        private double _valorOriginal;
        public double ValorOriginal
        {
            get { return _valorOriginal; }
            set { _valorOriginal = value; }
        }

        private List<ParcelaModel> _parcelas;
        public List<ParcelaModel> Parcelas
        {
            get { return _parcelas; }
            set { _parcelas = value; }
        }
    }
}
