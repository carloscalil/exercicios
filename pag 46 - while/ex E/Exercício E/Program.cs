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
            double cont=0, resultado=0;

            Console.Write("O valor das potências de 3 são:");
            Console.WriteLine();

            while (cont <= 15)
            {
                if (cont == 0)
                {
                    resultado = 1;
                    Console.WriteLine("3 elavado a {0} = {1}", cont, resultado);
                }
                else
                {
                    if (cont == 1)
                    {
                        resultado = 3;
                        Console.WriteLine("3 elavado a {0} = {1}", cont, resultado);
                    }
                    else
                    {
                        resultado = resultado * 3;
                        Console.WriteLine("3 elavado a {0} = {1}", cont, resultado);
                    }
                }
                cont++;
            }
            Console.ReadKey();
        }
    }
}
