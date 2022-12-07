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
        else
        {
          return false;
        }

      }
      else
      {
        return false;
      }

    }

    public void PreencherDados()
    {
      Endereco endPessoaF = new Endereco();


      endPessoaF.logradouro = "Qn 29 Conj 67";

      endPessoaF.numero = 55;

      endPessoaF.comercial = false;




      this.nome = Console.ReadLine();

      this.endereco = endPessoaF;

      this.rendimento = float.Parse(Console.ReadLine());

      this.cpf = Console.ReadLine();

      this.dataNascimento = Console.ReadLine();

    }

    public void Imprimir()
    {


      Console.WriteLine(@$"

Nome: {this.nome}

Data de Nascimento: {this.dataNascimento}

Maior de idade?: {this.ValidaDataNascimento(this.dataNascimento)}

Rendimento Bruto: {this.rendimento}
Rendimento liquido: {this.PagarImposto(this.rendimento)}

            ");

    }
  }


}