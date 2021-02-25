using System.Collections.Generic;

namespace Financeiro.Domain.Entidades
{
  public class Pessoa : EntidadeBase
  {
    public string Nome { get; set; }
    public int CPF { get; set; }
    public virtual IEnumerable<Divida> Divida { get; private set; }
  }
}
