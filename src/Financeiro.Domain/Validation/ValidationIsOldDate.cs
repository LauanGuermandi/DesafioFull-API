using System;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Domain.Validation
{
    public class ValidationIsOldDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dataVencimento;

            bool parsed = DateTime.TryParse(value as string, out dataVencimento);
            if(!parsed)
                return false;

            bool isOldDate = DateTime.Compare(dataVencimento, DateTime.UtcNow) < 0;
            if (!isOldDate) {
                return false;
            }

            return true;
        }
    }
}

