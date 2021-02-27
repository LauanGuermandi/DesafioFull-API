using System;
using System.ComponentModel.DataAnnotations;
using Financeiro.Domain.Validation;

namespace Financeiro.Domain.Dtos.ParcelaDtos
{
    public class ParcelaDto
    {
        [Required(ErrorMessage = "O campo 'Numero da parcela' é obrigatório.")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo 'Data de vencimento' é obrigatório.")]
        [ValidationIsOldDate(ErrorMessage = "A Data de vencimento deve ser uma data anterior ao dia de hoje.")]
        public string DataVencimento { get; set; }

        [Required(ErrorMessage = "O campo 'Valor' é obrigatório.")]
        public double Valor { get; set; }
    }
}
