using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstrutorDefault
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public string GetPessoa()
        {
            return $"Nome: {Nome}\nIdade: {Idade}\nPeso: {Peso}\nAltura: {Altura}";
        }
    }
}
