using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, resultado, cont;

            Console.Write("Digite o valor para se fazer a tabuada: ");
            valor = int.Parse(Console.ReadLine());

            for (cont = 1; cont <= 20; cont++)
            {
                resultado = valor * cont;

                Console.WriteLine("{0} * {1} = {2}", valor, cont, resultado);
            }
            Console.ReadKey();
        }
    }
}
