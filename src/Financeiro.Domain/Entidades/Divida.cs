using System;

namespace Financeiro.Domain.Entidades
{
  public class Divida : EntidadeBase
  {
    public double ValorOriginal { get; private set; }
    public DateTime DataVencimento { get; private set; }
    public Guid PessoaId { get; set; }
    public Pessoa Pessoa { get; set; }
  }
}
