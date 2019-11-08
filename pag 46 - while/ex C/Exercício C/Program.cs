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
            int resultado = 0, cont = 1;

            Console.WriteLine("Aperte qualquer letra para ver a soma dos números pares de 1 a 500.");
            Console.ReadKey();
            Console.WriteLine();
     
            while (cont <= 500)
            {
                if (cont % 2 == 0)
                {
                    resultado = resultado + cont;
                }
                cont++;
            }
            Console.WriteLine("A soma: {0}", resultado);
            Console.ReadKey();
        }
    }
}
