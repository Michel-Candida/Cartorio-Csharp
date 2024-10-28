using System;

namespace Cartorio
{
    
    public class Pessoa
    {
        private string nome;
        public string Nome {get; set;}
        private string email;
        public string Email {get; set;}
        private string telefone;
        public string Telefone {get; set;}
        
        // Construtor 
        public Pessoa(string nome, string email, string telefone)
        {
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
        }

        // Método para calcular o valor das cópias
        public double ValorDeCopia(int quantidade)
        {
            return quantidade * 1.0;
        }
    }
}
