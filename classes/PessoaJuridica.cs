using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeBackend.interfaces;

namespace AtividadeBackend.classes
{
  public class PessoaJuridica : Pessoa, IPessoaJuridica
  {
    public string razaoSocial;

    public string cnpj;

    public bool ValidarCnpj(string parCnpj)
    {
      throw new NotImplementedException();
    }
  }
}