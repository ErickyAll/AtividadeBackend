using AtividadeBackend.classes;

Endereco endPessoaF = new Endereco();

endPessoaF.logradouro = "Rua lala 01";
endPessoaF.numero = 15;
endPessoaF.comercial = false;

PessoaFisica novaPessoaFisica = new PessoaFisica();

novaPessoaFisica.nome = "Erick";
novaPessoaFisica.endereco = endPessoaF;
novaPessoaFisica.rendimento = 1000f;
novaPessoaFisica.cpf = "123456789-00";
System.Console.WriteLine(novaPessoaFisica.ValidaDataNascimento("22/07/2003"));


// Endereco endPJ = new Endereco();

// endPJ.logradouro = "Rua do Senai";
// endPJ.numero = 15;
// endPJ.comercial = true;

// PessoaJuridica newPJ = new PessoaJuridica();

// newPJ.cnpj = "992929292";
// newPJ.endereco = endPJ;
// newPJ.razaoSocial = "Senai";
// newPJ.rendimento = 900000f;
// newPJ.nome = "Eduardo Costa";

// System.Console.WriteLine(newPJ.rendimento);