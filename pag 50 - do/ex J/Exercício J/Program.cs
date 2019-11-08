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
            double a, b, resultado=0,cont=0;

            Console.Write("Digite o dividendo: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o divisor: ");
            b = double.Parse(Console.ReadLine());

            do
            {
                resultado = a - b;
                a = resultado;
                cont++;
            } while (resultado >= 0);
            Console.WriteLine();
            Console.WriteLine("O resultado inteiro da divisão é: {0}", cont - 1);
            Console.ReadKey();
        }
    }
}
