using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exBp100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler duas matrizes A e B, cada uma com uma dimensão para 7 elementos. Construir uma matriz C de duas dimensões, 
             * em que a primeira coluna deverá ser formada pelos elementos da matriz A
             * e a segunda coluna deverá ser formada pelos elementos da matriz B. Apresentar a matriz C.*/

            double[] a = new double[7];
            double[] b = new double[7];
            double[,] c = new double[7, 2];
            int i, j;

            for (i = 0; i < 7; i++)
            {
                Console.Write("Digite o {0}° valor de A : ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
                c[i, 0] = a[i];
            }
            for (j = 0; j < 7; j++)
            {
                Console.Write("Digite o {0}° valor de B : ", j + 1);
                b[j] = double.Parse(Console.ReadLine());
                c[j, 1] = b[j];
            }

            for (i = 0; i < 7; i++)
            {
                for (j = 0; j < 2; j++)
                {
                    Console.WriteLine(" O elemento [{0},{1}] da matriz C é: {2}", i + 1, j + 1, c[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
