using AtividadeBackend.classes;
using System.Text.RegularExpressions;


PessoaFisica metodosPF = new PessoaFisica();
PessoaJuridica metodosPJ = new PessoaJuridica();


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

  System.Console.WriteLine($"Opção:");
  opcao = Console.ReadLine();


  switch (opcao)
  {
    case "1":

      List<PessoaFisica> cadastroPF = new List<PessoaFisica>(); //Lista de pessoas fisícas

      string opcaoPF;
      do
      {


        Console.Clear();
        System.Console.WriteLine(@$"
            
  ================================================
  |            Escolha uma opção                 |
  |----------------------------------------------|
  |      1 - Cadastrar Pessoa Física             |
  |      2 - Listar Pessoa Física                |
  |                                              |
  |            0 - Voltar                        |
  ================================================
            
            "
        );

        System.Console.Write($"Escolha uma opção:");
        opcaoPF = Console.ReadLine();

        switch (opcaoPF)
        {
          case "1":


            Endereco endPessoaF = new Endereco();

            // System.Console.WriteLine($"Informe seu endereço:");
            // endPessoaF.logradouro = Console.ReadLine();
            // System.Console.WriteLine($"Numero:");
            // endPessoaF.numero = int.Parse(Console.ReadLine());
            // System.Console.WriteLine($"Endereço comercial? S/N");
            // string endcomercial = Console.ReadLine();

            // if (endcomercial.ToUpper() == "S")
            // {
            //   endPessoaF.comercial = true;
            // }
            // else
            // {
            //   endPessoaF.comercial = false;
            // }

            PessoaFisica novaPessoaFisica = new PessoaFisica();
            novaPessoaFisica.PreencherDados();
            // System.Console.WriteLine($"Nome:");
            // novaPessoaFisica.nome = Console.ReadLine();

            // novaPessoaFisica.endereco = endPessoaF;
            // System.Console.WriteLine($"Qual seu rendimento?");
            // novaPessoaFisica.rendimento = float.Parse(Console.ReadLine());
            // System.Console.WriteLine($"Digite seu CPF:");
            // novaPessoaFisica.cpf = Console.ReadLine();
            // System.Console.WriteLine("Data de Nascimento:");
            // novaPessoaFisica.dataNascimento = Console.ReadLine();

            cadastroPF.Add(novaPessoaFisica);

            using ( StreamWriter arquivo = new StreamWriter($"./DadosPF/PessoasFisicas.txt", append: true) )
            {
              arquivo.WriteLine(@$"{novaPessoaFisica.nome}, {novaPessoaFisica.dataNascimento}, {novaPessoaFisica.cpf}, {novaPessoaFisica.endereco.logradouro}");
              arquivo.Close();
            }
          

            Utils.ParadaConsole("Cadastro feito com sucesso!");

            break;
          case "2":

            System.Console.WriteLine($"***** Lista Pessoas Físicas *****");
            System.Console.WriteLine();

              using (StreamReader arquivo = new StreamReader($"./DadosPF/PessoasFisicas.txt"))
                {
                  string linha;

                  while ((linha = arquivo.ReadLine()) != null)
                  {
                      System.Console.WriteLine($"{linha}");
                  }
                }

            // if (cadastroPF.Count > 0)
            // {

            //   foreach (var pf in cadastroPF)
            //   {
            //     //pf.Imprimir();

              

            //   }
            // }
            // else
            // {
            //   Console.ForegroundColor = ConsoleColor.DarkRed;
            //   Console.WriteLine($"Lista Vazia");
            //   Console.ResetColor();
            //   Thread.Sleep(2000);
            // }


            Utils.ParadaConsole("Fim da Listagem");
            break;
          case "0":

            Utils.ParadaConsole("Voltando");

            break;
          default:

            Utils.ParadaConsole("Opção Invalida.");

            break;
        }

      } while (opcaoPF != "0");




      Console.ForegroundColor = ConsoleColor.Green;
      System.Console.WriteLine($"Aperte ENTER para continuar");
      Console.ReadLine();
      Console.ResetColor();

      break;

    case "2":

      List<PessoaJuridica> cadastroPJ = new List<PessoaJuridica>(); //Lista de pessoas Juridicas

      string opcaoPJ;
      do
      {

        Console.Clear();
        System.Console.WriteLine(@$"
            
  ================================================
  |            Escolha uma opção                 |
  |----------------------------------------------|
  |      1 - Cadastrar Pessoa Juridica           |
  |      2 - Listar Pessoa Juridica              |
  |                                              |
  |            0 - Voltar                        |
  ================================================
            
            "
        );

        System.Console.Write($"Escolha uma opção:");
        opcaoPJ = Console.ReadLine();

        switch (opcaoPJ)
        {

          case "1":

            Endereco endPJ = new Endereco();

            endPJ.logradouro = "Rua do Senai";
            endPJ.numero = 15;
            endPJ.comercial = true;

            PessoaJuridica newPJ = new PessoaJuridica();

            newPJ.cnpj = "99.888.999/0001-90";
            newPJ.razaoSocial = "Senai";
            newPJ.rendimento = 100000f;
            newPJ.nome = "Eduardo Costa";

            cadastroPJ.Add(newPJ);
            Utils.ParadaConsole("Cadastro feito com sucesso!");

            break;
          case "2":

            System.Console.WriteLine($"***** Lista Pessoas Juridicas *****");
            System.Console.WriteLine();

            foreach (var pj in cadastroPJ)
            {
              System.Console.WriteLine();
              System.Console.WriteLine($"Razão Social: {pj.razaoSocial}");
              System.Console.WriteLine($"CNPJ: {pj.cnpj}");
              System.Console.WriteLine($"CNPJ Valido?: {metodosPJ.ValidarCnpj(pj.cnpj)}");
              System.Console.WriteLine($"Rendimento Bruto: {pj.rendimento}");
              System.Console.WriteLine($"Rendimento Liquido: {metodosPJ.PagarImposto(pj.rendimento)}");
            }


            Utils.ParadaConsole("Fim da Listagem");

            break;
          case "0":

            Utils.ParadaConsole("Voltando");

            break;
          default:

            Utils.ParadaConsole("Opção Invalida.");

            break;

        };

      } while (opcaoPJ != "0");
      break;


    case "0":


      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Green;
      Utils.ParadaConsole("Obrigado por utilizar nossos sistemas! :)");
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

