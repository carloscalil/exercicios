using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_E
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=0, impar=0;

            for (cont = 1; cont <= 20; cont++)
            {
                if (cont % 2 != 0)
                {
                    Console.WriteLine("{0}", cont);
                }
            }
            Console.ReadKey();
        }
    }
}
