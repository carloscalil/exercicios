using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_L
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, resultado;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());

            resultado = Math.Pow(a + b + c, 2);

            Console.WriteLine();
            Console.WriteLine("A quadrado da soma dos três valores é: {0}", resultado);
            Console.ReadKey();
        }
    }
}
