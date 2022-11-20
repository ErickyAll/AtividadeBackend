using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeBackend.interfaces;

namespace AtividadeBackend.classes
{
  public class PessoaFisica : Pessoa, IPessoaFisica
  {
    public string? cpf;

    public string? dataNascimento { get; set; }

    public override float PagarImposto(float paRendimento)
    {
      if (paRendimento <= 1500)
      {
        return paRendimento;

      }
      else if (paRendimento > 1501 && paRendimento <= 5000)
      {
        return paRendimento - (paRendimento / 100) * 3;
      }

      return paRendimento - (paRendimento / 100) * 5;


    }

    public bool ValidaDataNascimento(string parDtN)
    {
      DateTime dtC;

      if (DateTime.TryParse(parDtN, out dtC))
      {
        DateTime dataAtual = DateTime.Today;

        double anos = (dataAtual - dtC).TotalDays / 365;

        if (anos >= 18)
        {
          return true;
        }

      }



      return false;
    }
  }
}