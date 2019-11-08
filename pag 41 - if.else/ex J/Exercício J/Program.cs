using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_J
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            Console.Write("Digite o valor: ");
            a = double.Parse(Console.ReadLine());

            if ((a >= 1) && (a <= 9))
            {
                Console.WriteLine("===============================");
                Console.WriteLine("O valor está na faixa permitida.");
            }
            else
            {
                Console.WriteLine("====================================");
                Console.WriteLine("O valor está fora da faixa permitida.");
            }
            Console.ReadKey();
        }
    }
}
