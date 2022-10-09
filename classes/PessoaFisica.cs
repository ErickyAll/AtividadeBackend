using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeBackend.interfaces;

namespace AtividadeBackend.classes
{
  public class PessoaFisica : Pessoa, IPessoaFisica
  {
    public string cpf;

    public DateTime dataNascimento;

    public bool ValidaDataNascimento(string parDtNascimento)
    {
      throw new NotImplementedException();
    }
  }
}