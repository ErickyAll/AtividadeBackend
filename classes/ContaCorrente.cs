using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeBackend.classes
{
  public class ContaCorrente : Conta
  {

    public string correntista { get; set; }

    public ContaCorrente(string ag, string conta, double saldo, string correntista) : base(ag, conta, saldo)

    {

      this.correntista = correntista;
    }

  }
}