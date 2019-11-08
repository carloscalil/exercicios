using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont=1, numero;

            do
            {
                if (cont % 4 == 0)
                {
                    Console.WriteLine("{0}", cont);
                }
                cont++;
            } while (cont <= 200);
            Console.ReadKey();
        }
    }
}
