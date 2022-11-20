using AtividadeBackend.classes;
using System.Text.RegularExpressions;


PessoaFisica metodosPF = new PessoaFisica();
PessoaJuridica metodosPJ = new PessoaJuridica();

Endereco endPessoaF = new Endereco();

endPessoaF.logradouro = "Rua lala 01";
endPessoaF.numero = 15;
endPessoaF.comercial = false;

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = Console.ReadLine();
novaPessoaFisica.endereco = endPessoaF;
novaPessoaFisica.rendimento = 1800f;
novaPessoaFisica.cpf = "123456789-00";
novaPessoaFisica.dataNascimento = "22/07/2003";


Console.WriteLine(@$"

Nome: {novaPessoaFisica.nome}

Data de Nascimento: {novaPessoaFisica.dataNascimento}

Maior de idade?: {metodosPF.ValidaDataNascimento(novaPessoaFisica.dataNascimento)}

Rendimento Bruto: {novaPessoaFisica.rendimento}
Rendimento liquido: {metodosPF.PagarImposto(novaPessoaFisica.rendimento)}

");





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

// System.Console.WriteLine(newPJ.rendimento);


// **********************Regex

// string data = "22/02/2030";

// bool dataV = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

// System.Console.WriteLine(dataV);

//*****************************

