using System;

namespace Cartorio
{
    public class PessoaFisica:Pessoa
    {
        private string cpf;
        public string CPF {get; set;}
        private string rg;
        public string RG {get; set;}

        
        public PessoaFisica(string nome, string email, string telefone, string cpf, string rg):base(nome, email, telefone)
        {
            this.CPF = cpf;
            this.RG = rg;
        }
      
        public double ValorDeCopia(int quantidade)
        {
            double valorPessoa = base.ValorDeCopia(quantidade); 
            return valorPessoa  + (quantidade * 1);
            
        }
    }
}