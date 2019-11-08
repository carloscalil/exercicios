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
            int cont, resultado=3;

            for (cont=0; cont<=15; cont++)
            {
                if (cont == 0)
                {
                    Console.WriteLine("1");
                }
                else
                {
                    if (cont == 1)
                    {
                        Console.WriteLine("{0}", resultado);
                    }
                    else
                    {
                        resultado = resultado * 3;
                        Console.WriteLine("{0}", resultado);
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
