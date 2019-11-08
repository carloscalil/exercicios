using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_J
{
    class Program
    {
        static void Main(string[] args)
        {
            int f=0, cont;

            for (cont=10; cont<=100; cont=cont+10)
            {
                f = (9 * cont + 160) / 5;
                Console.WriteLine("{0} celsius = {1} fahrenheit", cont, f);                
            }
            Console.ReadKey();
        }
    }
}
