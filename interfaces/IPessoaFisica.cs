using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeBackend.interfaces
{
  public interface IPessoaFisica
  {
    bool ValidaDataNascimento(string parDtNascimento);
  }
}