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

    public DateTime dataNascimento { get; set; }

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