using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AtividadeBackend.interfaces;
namespace AtividadeBackend.classes
{

  //sem PUBLIC na frente = internal = somente visivel no namespace que foi criado
  public abstract class Pessoa : IPessoa
  {
    public string? nome;

    public Endereco? endereco;

    public float rendimento;

    public abstract float PagarImposto(float paRendimento);

  }
}