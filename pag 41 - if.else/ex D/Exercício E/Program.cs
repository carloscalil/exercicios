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
            double a, b, c, delta, x1, x2;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                delta = Math.Pow(b, 2) - 4 * a * c;
                
                if (delta < 0)
                {
                    Console.WriteLine("=======================");
                    Console.WriteLine("A raiz deu negativa!");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("=======================");
                    Console.WriteLine("O valor de x1 é: {0}", x1);
                    Console.WriteLine("O valor de x2 é: {0}", x2);
                }
            }
            else
            {
                Console.WriteLine("==================================");
                Console.WriteLine("O valor de A não pode ser negativo!");
            }
            Console.ReadKey();
        }
    }
}
