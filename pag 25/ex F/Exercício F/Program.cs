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
            double a, b, c;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("");
            Console.WriteLine("O novo valor de A sera: {0}", a);
            Console.Write("O novo valor de B sera: {0}", b);

            Console.ReadKey();
        }
    }
}
