using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtividadeBackend.classes
{
  public class Endereco
  {
    public string? logradouro { get; set; }

    public int numero { get; set; }

    public bool comercial { get; set; }

    public bool residencial { get; set; }
  }
}