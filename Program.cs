using System;

namespace Cartorio
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PessoaFisica pessoafisica = new PessoaFisica("Michael", "Michael@gmail.com", "149885644", "12345678901", "1234565655");

            Console.WriteLine("Pessoa Física:");
            Console.WriteLine("Nome: " + pessoafisica.Nome);
            Console.WriteLine("E-mail: " + pessoafisica.Email);
            Console.WriteLine("Telefone: " + pessoafisica.Telefone);
            Console.WriteLine("CPF: " + pessoafisica.CPF);
            Console.WriteLine("RG: " + pessoafisica.RG);
            Console.WriteLine("Valor da cópia Pessoa Física: R$" + pessoafisica.ValorDeCopia(2));

            
            PessoaJuridica pessoajuridica = new PessoaJuridica("Empresa MVC", "empresa@email.com", "48252425", "123456", "MVC");

            Console.WriteLine("Pessoa Jurídica:");
            Console.WriteLine("Nome: " + pessoajuridica.Nome);
            Console.WriteLine("E-mail: " + pessoajuridica.Email);
            Console.WriteLine("Telefone: " + pessoajuridica.Telefone);
            Console.WriteLine("CNPJ: " + pessoajuridica.CNPJ);
            Console.WriteLine("Nome Fantasia: " + pessoajuridica.NomeFantasia);
            Console.WriteLine("Valor da cópia Pessoa Jurídica: R$" + pessoajuridica.ValorDeCopia(3));
        }
    }
}
