using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_H
{
    class Program
    {
        static void Main(string[] args)
        {
            int exp, base1, resultado=0, cont;

            Console.Write("Digite a base: ");
            base1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o expoente: ");
            exp = int.Parse(Console.ReadLine());

            for (cont = 1; cont <= exp; cont++)
            {
                if (cont == 1)
                {
                    resultado = base1;
                }
                else
                {
                    resultado = resultado * base1;
                }
            }
            Console.WriteLine("{0}", resultado);
            Console.ReadKey();
        }
    }
}
