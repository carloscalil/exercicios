using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;

            Console.Write("Digite o valor de A: ");
            A = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            B = double.Parse(Console.ReadLine());

            C = Math.Pow(A - B, 2);

            Console.WriteLine();
            Console.WriteLine("O valor do quadrado da diferença de A e B é: {0}", C);
            Console.ReadKey();
            
        }
    }
}
