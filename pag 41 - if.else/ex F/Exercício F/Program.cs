using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_F
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());

            if (a > b)
            {
                if (b > c)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("Ordem crescente: {0}, {1}, {2}", a, b, c);
                }
                else
                {
                    if (c > a)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("Ordem crescente: {0}, {1}, {2}", c, a,b);
                    }
                    else
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("Ordem crescente: {0}, {1}, {2}", a, c, b);
                    }
                }
            }
            else
            {
                if (a > c)
                {
                    Console.WriteLine("===================");
                    Console.WriteLine("Ordem crescente: {0}, {1}, {2}", b, a, c);
                }
                else
                {
                    if (b > c)
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("Ordem crescente: {0}, {1}, {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("===================");
                        Console.WriteLine("Ordem crescente: {0}, {1}, {2}", c, b, a);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
