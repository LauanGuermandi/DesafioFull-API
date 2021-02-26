using System.Data;
using System;

namespace Financeiro.Domain.Models
{
    public class PessoaModel : BaseModel
    {
        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _cpf;
        public string CPF
        {
            get { return _cpf; }
            set { _cpf = value; }
        }
    }
}
