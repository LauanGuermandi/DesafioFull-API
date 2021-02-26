using System;

namespace Financeiro.Domain.Dtos.PessoaDtos
{
    public class PessoaDto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
