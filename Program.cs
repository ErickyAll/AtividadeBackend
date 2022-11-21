using AtividadeBackend.classes;
using System.Text.RegularExpressions;


Console.Clear();

Console.WriteLine(@$"
==================+++++++===================
|  Bem vindo ao sistema de cadastro de   |
|      pessoas físicas e juridicas       |
==========================================
");

Utils.loading("Carregando");

string opcao;

do
{
  Console.Clear();
  Console.WriteLine(@$"
================================================
|            Escolha uma opção                 |
|----------------------------------------------|
|            1 - Pessoa Física                 |
|            2 - Pessoa Juridica               |
|                                              |
|            0 - Sair                          |
================================================
");

  opcao = Console.ReadLine();

  switch (opcao)
  {
    case "1":
      PessoaFisica metodosPF = new PessoaFisica();

      Endereco endPessoaF = new Endereco();

      endPessoaF.logradouro = "Rua lala 01";
      endPessoaF.numero = 15;
      endPessoaF.comercial = false;

      PessoaFisica novaPessoaFisica = new PessoaFisica();

      novaPessoaFisica.nome = Console.ReadLine();
      novaPessoaFisica.endereco = endPessoaF;
      novaPessoaFisica.rendimento = Console.Read();
      novaPessoaFisica.cpf = Console.ReadLine();
      novaPessoaFisica.dataNascimento = Console.ReadLine();


      Console.WriteLine(@$"

           Nome: {novaPessoaFisica.nome}

          Data de Nascimento: {novaPessoaFisica.dataNascimento}

          Maior de idade?: {metodosPF.ValidaDataNascimento(novaPessoaFisica.dataNascimento)}

         Rendimento Bruto: {novaPessoaFisica.rendimento}
         Rendimento liquido: {metodosPF.PagarImposto(novaPessoaFisica.rendimento)}

");

      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine($"Aperte ENTER para continuar");
      Console.ReadLine();
      Console.ResetColor();

      break;

    case "2":
      PessoaJuridica metodosPJ = new PessoaJuridica();

      Endereco endPJ = new Endereco();

      endPJ.logradouro = "Rua do Senai";
      endPJ.numero = 15;
      endPJ.comercial = true;

      PessoaJuridica newPJ = new PessoaJuridica();

      newPJ.cnpj = "99.888.999/0001-90";
      newPJ.razaoSocial = "Senai";
      newPJ.rendimento = 100000f;
      newPJ.nome = "Eduardo Costa";

      System.Console.WriteLine(metodosPJ.PagarImposto(newPJ.rendimento));

      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine($"Aperte ENTER para continuar");
      Console.ReadLine();
      Console.ResetColor();
      break;

    case "0":


      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine($"Obrigado por utilizar nossos sistemas! :)");
      Console.ResetColor();

      Utils.loading("Finalizando");
      break;

    default:
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Red;
      Console.WriteLine($"Opção invalida.");
      Console.ResetColor();
      Thread.Sleep(2000);

      break;
  }
} while (opcao != "0");








































// System.Console.WriteLine(newPJ.rendimento);


// **********************Regex

// string data = "22/02/2030";

// bool dataV = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

// System.Console.WriteLine(dataV);

//*****************************

