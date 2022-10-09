using AtividadeBackend.classes;

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Erick";
novaPessoaFisica.endereco = "casa 1";
novaPessoaFisica.rendimento = 1000f;
novaPessoaFisica.cpf = "123456789-00";

System.Console.WriteLine($"Nome:{novaPessoaFisica.nome}");