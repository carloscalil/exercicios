using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um algoritmo que leia 10 salários. Depois de lidos e armazenados, mostre o maior valor. Utilize vetores.*/
            double[] a = new double[10];
            double maior=0;
            int i;

            for (i = 0; i <= 9; i++) 
            {
                Console.Write("Digite o {0}º salário: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());

                if (a[i] >= maior)
                {
                    maior = a[i];
                }
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine("O maior salário é: {0}", maior);
            Console.ReadKey();
            
        }
    }
}
