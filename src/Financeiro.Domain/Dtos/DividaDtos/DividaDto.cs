using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Financeiro.Domain.Dtos.ParcelaDtos;

namespace Financeiro.Domain.Dtos.DividaDtos
{
    public class DividaDto
    {
        [Required(ErrorMessage = "O campo 'Devedor' é obrigatório.")]
        public Guid PessoaId { get; set; }

        [Range(0.1, int.MaxValue, ErrorMessage = "O campo 'Valor' não é válido")]
        public double ValorOriginal { get; set; }

        [Required(ErrorMessage = "O campo 'Número do título' é obrigatório.")]
        [StringLength(10, ErrorMessage = "O campo 'Número do título' é inválido.")]
        public string NumeroTitulo { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "O campo 'Porcentagem de juros' não é válido.")]
        public int PorcentagemJuros { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "O campo 'Porcentagem de Multa' não é válido.")]
        public int PorcentagemMulta { get; set; }

        [Required(ErrorMessage = "É necessário adicionar ao menos uma parcela.")]
        [MinLength(1, ErrorMessage = "É necessário adicionar ao menos uma parcela.")]
        public List<ParcelaDto> Parcelas { get; set; }
    }
}
