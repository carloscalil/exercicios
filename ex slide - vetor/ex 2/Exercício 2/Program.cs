using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Armazene num vetor de 5 posições o salário de 5 pessoas. Se o salário for menor q 1000 reais, 
              forneça um aumento de 10% e sobrescreva o valor antigo. Ao final, mostre a lista de salários atualizada.*/

            double[] a = new double[5];
            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º salário: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());

                if (a[i] < 1000)
                {
                    a[i] = a[i] * 1.1;
                }
            }
            for (i = 0; i <= 4; i++)
            {
                Console.WriteLine("O valor do {0}º salário será: {1}", i + 1, a[i]);
            }
            Console.ReadKey();
        }
    }
}
