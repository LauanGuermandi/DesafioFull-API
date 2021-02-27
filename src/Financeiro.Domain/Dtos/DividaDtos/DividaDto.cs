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

        [Required(ErrorMessage = "O campo 'Valor' é obrigatório.")]
        public double ValorOriginal { get; set; }

        [Required(ErrorMessage = "O campo 'Número do título' é obrigatório.")]
        [StringLength(10, ErrorMessage = "O campo 'Número do título' é inválido.")]
        public string NumeroTitulo { get; set; }

        [Required(ErrorMessage = "É necessário adicionar ao menos uma parcela.")]
        [MinLength(1, ErrorMessage = "É necessário adicionar ao menos uma parcela.")]
        public List<ParcelaDto> Parcelas { get; set; }
    }
}
