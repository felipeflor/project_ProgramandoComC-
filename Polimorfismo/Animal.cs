using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Animal
    {
        public virtual void aminalSound()
        {
            Console.WriteLine("O animal faz algum som");
        }
    }
}
