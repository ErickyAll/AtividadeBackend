using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using AtividadeBackend.interfaces;

namespace AtividadeBackend.classes
{
  public class PessoaJuridica : Pessoa, IPessoaJuridica
  {
    public string? razaoSocial;

    public string? cnpj;

    public override float PagarImposto(float paRendimento)
    {
      if (paRendimento <= 5000)
      {
        return paRendimento - (paRendimento / 100) * 6;

      }
      else if (paRendimento > 5001 && paRendimento <= 10000)
      {
        return paRendimento - (paRendimento / 100) * 8;
      }

      return paRendimento - (paRendimento / 100) * 10;


    }

    public bool ValidarCnpj(string parCnpj)
    {
      if (Regex.IsMatch(parCnpj, @"^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$"))
      {
        if (parCnpj.Length == 18)
        {
          if (parCnpj.Substring(11, 4) == "0001")
          {
            return true;
          }
        }
        else if (parCnpj.Length == 14)
        {
          if (parCnpj.Substring(8, 4) == "0001")
          {
            return true;
          }
        }


      }

      return false;
    }
  }
}