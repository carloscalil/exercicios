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
            double cont=1, resultado=0, base1, expoente;

            Console.Write("Digite o valor da base: ");
            base1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do expoente: ");
            expoente = double.Parse(Console.ReadLine());

            while (cont <= expoente)
            {
                if (cont == 1)
                {
                    resultado = base1;
                }
                else
                {
                    resultado = resultado * base1;
                }
                cont++;
            }

            Console.WriteLine("Resultado: {0}", resultado);
            Console.ReadKey();
        }
    }
}
