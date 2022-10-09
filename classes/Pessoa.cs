using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeBackend.interfaces;
namespace AtividadeBackend.classes
{
  public class Pessoa : IPessoa
  {
    public string nome;

    public string endereco;

    public float rendimento;

    public float PagarImposto(float paRendimento)
    {
      throw new NotImplementedException();
    }
  }
}