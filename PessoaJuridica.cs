using System;

namespace Cartorio
{
    public class PessoaJuridica:Pessoa
    {
        private string cnpj;
        public string CNPJ {get; set;}
        private string nomefantasia;
        public string NomeFantasia {get; set;}

        // Construtor 
        public PessoaJuridica(string nome, string email, string telefone, string cnpj, string nomefantasia):base(nome, email, telefone)
        {
            this.CNPJ = cnpj;
            this.NomeFantasia = nomefantasia;
        }

        public double ValorDeCopia(int quantidade)
        {
            double valorpessoa = base.ValorDeCopia(quantidade); 
            return valorpessoa + (quantidade * 2);
            
        }
    }
}