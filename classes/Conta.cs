using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeBackend.classes
{
  public abstract class Conta
  {
    public string? agencia { get; private set; }
    public string? conta { get; set; }
    private double saldo;


    public Conta(string parAgencia, string parConta, double parSaldo)
    {
      this.agencia = parAgencia;
      this.conta = parConta;
      this.saldo = parSaldo;
    }

    public void setAgencia(string Ag)
    {
      if (Ag.Length >= 3)
      {
        this.agencia = Ag;
      }
    }

    public void setSaldo(double parSaldo)
    {
      if (parSaldo > 0)
      {
        this.saldo = parSaldo;
      }
    }
    public double getSaldo()
    {
      return this.saldo;

    }
  }
}