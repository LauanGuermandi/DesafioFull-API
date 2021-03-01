using System.Collections;
using System;
using System.Collections.Generic;
using Financeiro.Domain.Dtos.ParcelaDtos;

namespace Financeiro.Domain.Dtos.DividaDtos
{
    public class DividaCalculadaDto
    {
        public Guid Id { get; set; }
        public string NomeDevedor { get; set; }

        public decimal PorcentagemJuros { get; set; }
        public decimal PorcentagemMulta { get; set; }

        public string NumeroTitulo { get; set; }
        public double ValorOriginal { get; set; }
        public double Multa { get; set; }
        public int DiasAtrasado { get; set; }
        public double ValorAtualizado { get; set; }

        public virtual IEnumerable<ParcelaCalculadaDto> Parcelas { get; set; }
    }
}
