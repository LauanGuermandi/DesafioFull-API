using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Financeiro.Domain.Dtos.ParcelaDtos;
using Financeiro.Domain.Validation;

namespace Financeiro.Domain.Dtos.DividaDtos
{
    public class DividaCreateDto
    {
        [Required(ErrorMessage = "O campo devedor é obrigatório.")]
        [StringLength(11, ErrorMessage = "CPF inválido.")]
        public int CPF { get; set; }

        [ValidateEachItem(ErrorMessage = "Formato de dados inválido(Divida).")]
        public List<DividaDto> Dividas { get; set; }

        [ValidateEachItem(ErrorMessage = "Formato de dados inválido(Parcela).")]
        public List<ParcelaDto> Parcelas { get; set; }
    }
}
