using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_D
{
    class Program
    {
        static void Main(string[] args)
        {
            int impar, cont=1;

            Console.Write("Aperte qualquer letra para ver os números ímpares de 0 a 20.");
            Console.ReadKey();
            Console.WriteLine();

            while (cont <= 20)
            {
                if (!(cont % 2 == 0))
                {
                    Console.WriteLine("{0}", cont);
                }
                cont++;
            }
            Console.ReadKey();
        }
    }
}
