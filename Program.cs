using AtividadeBackend.classes;
using System.Text.RegularExpressions;
// Endereco endPessoaF = new Endereco();

// endPessoaF.logradouro = "Rua lala 01";
// endPessoaF.numero = 15;
// endPessoaF.comercial = false;

// PessoaFisica novaPessoaFisica = new PessoaFisica();

// novaPessoaFisica.nome = "Erick";
// novaPessoaFisica.endereco = endPessoaF;
// novaPessoaFisica.rendimento = 1000f;
// novaPessoaFisica.cpf = "123456789-00";
// System.Console.WriteLine(novaPessoaFisica.ValidaDataNascimento("22/07/2003"));


// Endereco endPJ = new Endereco();

// endPJ.logradouro = "Rua do Senai";
// endPJ.numero = 15;
// endPJ.comercial = true;

PessoaJuridica newPJ = new PessoaJuridica();

newPJ.cnpj = "99.888.999/0001-90";
newPJ.razaoSocial = "Senai";
newPJ.rendimento = 5000f;
newPJ.nome = "Eduardo Costa";

System.Console.WriteLine(newPJ.PagarImposto(newPJ.rendimento));

// System.Console.WriteLine(newPJ.rendimento);


// **********************Regex

// string data = "22/02/2030";

// bool dataV = Regex.IsMatch(data, @"^\d{2}/\d{2}/\d{4}$");

// System.Console.WriteLine(dataV);

//*****************************

