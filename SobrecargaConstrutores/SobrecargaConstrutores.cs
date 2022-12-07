using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaConstrutores
{
    //Exercicios pg. 188 e 189
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Pessoa(double peso, double altura)
        {
            this.Peso = peso;
            this.Altura = altura;
        }

        public Pessoa(string nome, double peso, double altura)
        {
            this.Nome = nome;
            this.Peso = peso;
            this.Altura = altura;
        }
    }
}
