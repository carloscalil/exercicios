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
            int a, b, c, d;

            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de D: ");
            d = int.Parse(Console.ReadLine());

            Console.WriteLine("===============");

            if ((a % 2 == 0) && (a % 3 == 0))
            {
                Console.WriteLine("A é divisivel por 2 e 3.");
            }
            if ((b % 2 == 0) && (b % 3 == 0))
            {
                Console.WriteLine("B é divisivel por 2 e 3."); 
            }
            if ((c % 2 == 0) && (c % 3 == 0))
            {
                Console.WriteLine("C é divisivel por 2 e 3.");
            }
            if ((d % 2 == 0) && (d % 3 == 0))
            {
                Console.WriteLine("D é divisivel por 2 e 3.");
            }
            Console.ReadKey();
        }
    }
}
