using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_F
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler duas matrizes do tipo vetor, sendo A com 20 elementos e B com 30 elementos. Construir uma
            matriz C, sendo esta a junção das duas outras matrizes.Desta forma, C deverá ter a capacidade de
           armazenar 50 elementos.Apresentar a matriz C.*/

            double[] A = new double[20];            double[] B = new double[30];
            double[] C = new double[50];
            int i;

            for (i = 0; i <= 19; i++)
            {
                Console.Write("Insira o {0}° de A: ", i + 1);
                A[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 29; i++)
            {
                Console.Write("Insira o {0}° de B: ", i + 1);
                B[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 49; i++)
            {
                if (i <= 19)
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i - 20];
                }
                Console.WriteLine("O {0}° valor de C é: {1}", i + 1, C[i]);
            }
            Console.ReadKey();

        }
    }
}
