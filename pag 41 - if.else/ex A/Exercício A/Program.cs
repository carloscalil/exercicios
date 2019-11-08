using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_A
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c;

            Console.Write("Digite o valor de A: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = float.Parse(Console.ReadLine());

            if (a > b)
            {
                c = a - b;
            }
            else
            {
                c = b - a;
            }

            Console.WriteLine("=============================");
            Console.WriteLine("O valor da diferença será: {0}", c);
            Console.ReadKey();
        }
    }
}
