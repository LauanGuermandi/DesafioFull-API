using System;
using System.ComponentModel.DataAnnotations;

namespace Financeiro.Domain.Entidades
{
  public abstract class EntidadeBase
  {
    [Key]
    public Guid Id { get; set; }
    private DateTime? _dataCriacao;
    public DateTime? DataCriacao
    {
      get { return _dataCriacao; }
      set { _dataCriacao = (value == null ? DateTime.UtcNow : value); }
    }
    public DateTime DataAtualizacao { get; set; }
  }
}
