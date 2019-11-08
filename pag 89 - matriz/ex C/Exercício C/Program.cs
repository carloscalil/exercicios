using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[15];
            int[] b = new int[15];
            int i, j, x;

            for(i = 0; i <= 14; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            for(i = 0; i <= 14; i++)
            {
                b[i] = a[i] / 2;
            }
            //Ordenação
            for (i = 0; i <= 14; i++)
            {
                for (j = i + 1; j <= 14; j++)
                {
                    if (a[i] < a[j])
                    {
                        x = a[i];
                        a[i] = a[j];
                        a[j] = x;
                    }
                }
            }
            for (i = 0; i <= 14; i++)
            {
                for (j = i + 1; j <= 14; j++)
                {
                    if (b[i] > b[j])
                    {
                        x = b[i];
                        b[i] = b[j];
                        b[j] = x;
                    }
                }
            }
            for (i = 0; i <= 14; i++)
            {
                Console.WriteLine("A - {0} / B - {1}",a[i], b[i]);
            }
            Console.ReadKey();
        }
    }
}
