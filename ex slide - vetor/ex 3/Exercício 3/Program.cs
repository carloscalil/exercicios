using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faca um programa q leia n valores reais. Armazene estes valores num vetor. Ao final, imprima a média aritmética destes valores.*/

            double[] a = new double[5];
            double media=0;
            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º valor real: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());

                media = media + a[i];
            }
            media = media / 5;

            Console.WriteLine("--------------------------");
            Console.WriteLine("O valor da média é: {0}", media);
            Console.ReadKey();
        }
    }
}
