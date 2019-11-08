using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_K
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, resultado=1, i;

            for (cont = 1; cont <= 10; cont++)
            {
                if (cont % 2 == 1)
                {
                    for (i = 1; i <= cont; i++)
                    {
                        resultado = resultado * i;             
                    }
                    Console.WriteLine("{0}", resultado);
                    resultado = 1;
                }
            }
            Console.ReadKey();
        }
    }
}
