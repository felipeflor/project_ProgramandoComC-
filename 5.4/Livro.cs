using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    internal class Livro : Produto
    {
        public short NPaginas { get; set; }
        //Sobrescreve o método
        public override string ExibirDados()
        {
            return base.ExibirDados() +
            "\nNº de Páginas: " + NPaginas.ToString();
        }
    }
}
