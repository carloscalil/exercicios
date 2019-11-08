using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_G
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont=1, resultado1=0, resultado2=0, auxiliar=0;

            Console.Write("O 10 primeiros valores da sequência de Fibonacci são:");
            Console.WriteLine();
            Console.WriteLine();

            while (cont <= 15)
            {
                if (cont == 1)
                {
                    resultado2 = 1;
                    Console.WriteLine("{0}", resultado2);
                }
                else
                {
                    if (cont == 2)
                    {
                        resultado1 = resultado2;
                        resultado2 = 1;
                        Console.WriteLine("{0}", resultado2);
                    }
                    else
                    {
                        auxiliar = resultado1 + resultado2;
                        resultado1 = resultado2;
                        resultado2 = auxiliar;
                        Console.WriteLine("{0}", resultado2);
                    }                 
                }
                cont++;
            }
            Console.ReadKey();
        }
    }
}
