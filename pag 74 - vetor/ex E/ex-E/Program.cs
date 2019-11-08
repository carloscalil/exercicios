using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_E
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler duas matrizes A e B do tipo vetor com 15 elementos cada. Construir uma matriz C, sendo esta a
            junção das duas outras matrizes. Desta forma, C deverá ter o dobro de elementos, ou seja, 30.
            Apresentar a matriz C. */

            double[] A = new double[15];            double[] B = new double[15];
            double[] C = new double[30];
            int i;

            for (i = 0; i <= 14; i++)
            {
                Console.WriteLine("Insira o {0}° de A: ", i + 1);
                A[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 14; i++)
            {
                Console.WriteLine("Insira o {0}° de B: ", i + 1);
                B[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 29; i++)
            {
                if (i <= 14)
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i-15];
                }
                Console.WriteLine("O {0}° valor de C é: {1}", i + 1,C[i]);                
            }
            Console.ReadKey();
        }
    }
}
