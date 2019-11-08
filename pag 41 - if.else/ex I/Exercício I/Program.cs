using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Digite o valor: ");
            a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("==================");
                Console.WriteLine("O número é par!");
            }
            else
            {
                Console.WriteLine("=================");
                Console.WriteLine("O número é ímpar!");
            }
            Console.ReadKey();
        }
    }
}
