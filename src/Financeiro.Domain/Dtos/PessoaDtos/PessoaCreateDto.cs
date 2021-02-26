using System.ComponentModel.DataAnnotations;
using Financeiro.Domain.Validation;

namespace Financeiro.Domain.Dtos.PessoaDtos
{
    public class PessoaCreateDto
    {
        [Required(ErrorMessage = "O campo 'Nome' é obrigatório.")]
        [MaxLength(255, ErrorMessage = "O campo 'Nome' deve conter no máximo 255 caracteres")]
        [MinLength(3, ErrorMessage = "O campo 'Nome' deve conter no mínimo 3 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo 'CPF' é obrigatório.")]
        [ValidationCpf(ErrorMessage = "O campo 'CPF' está em formato inválido.")]
        public string CPF { get; set; }
    }
}
