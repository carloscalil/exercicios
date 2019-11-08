using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_7
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] k = new double[15];
            int i;

            for (i = 0; i <= 14; i++)
            {
                Console.Write("Digite o {0}º valor: ", i + 1);
                k[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------");
            for (i = 0; i <= 14; i++)
            {
                Console.WriteLine("O {0}º valor digitado foi: {1}", i + 1, k[i]);
            }
            Console.WriteLine("");
            for (i = 0; i <= 14; i++)
            {
                if ((k[i] == 2) || (k[i] == 3))
                {
                    Console.WriteLine("O {0}º valor é primo, sendo ele: {1}", i + 1, k[i]);
                }
                else
                {
                    if ((k[i] % 2 != 0) && (k[i] % 3 != 0))
                    {
                        Console.WriteLine("O {0}º valor é primo, sendo ele: {1}", i + 1, k[i]);
                    }
                }                
            }
            Console.ReadKey();
        }
    }
}
