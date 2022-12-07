using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorPersonalizado
{
    internal class Pessoa
    {
        public Pessoa(string nome, int idade, double peso, double altura)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Peso = peso;
            this.Altura = altura;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public string GetPessoa()
        {
            return $"Nome: {this.Nome}, Idade: {this.Idade}, Peso: {this.Peso}, Altura: {this.Altura}";
        }

    }
}
