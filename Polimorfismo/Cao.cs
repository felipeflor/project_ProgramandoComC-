using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Cao : Animal
    {
        public override void aminalSound()
        {
            Console.WriteLine("O Cão faz: au, au");
        }
    }
}
