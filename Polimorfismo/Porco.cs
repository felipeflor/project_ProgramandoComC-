using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    internal class Porco : Animal
    {
        public override void aminalSound()
        {
            Console.WriteLine("O porco faz: oinc, oinc");
        }
    }
}
