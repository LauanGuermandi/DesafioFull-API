using System;

namespace Financeiro.Domain.Dtos.DividaDtos
{
    public class DividaResultDto
    {        
        public Guid Id { get; set; }
        public double ValorOriginal { get; set; }
        public string NumeroTitulo { get; set; }
    }
}
