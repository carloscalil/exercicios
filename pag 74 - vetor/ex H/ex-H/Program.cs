using System;

namespace ex_H
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler três matrizes (A, B e C) de uma dimensão com 5 elementos cada. Construir uma matriz D,
            sendo esta a junção das três outras matrizes. Desta forma D deverá ter o triplo de elementos, ou
            seja, 15. Apresentar os elementos da matriz D.*/
            double[] A = new double[5];
            double[] B = new double[5];
            double[] C = new double[5];
            double[] D = new double[15];
            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º valor de A: ", i + 1);
                A[i]=double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º valor de B: ", i + 1);
                B[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º valor de C: ", i + 1);
                C[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 14; i++)
            {
                if (i <= 4)
                {
                    D[i] = A[i];
                }
                if (i>=5 && i <= 9)
                {
                    D[i] = B[i-5];
                }
                if (i >= 10 && i <= 14)
                        {
                    D[i] = C[i-10];
                }
                Console.WriteLine("{0}º valor de D: {1}", i + 1, D[i]);
                Console.ReadKey();
            }
        }
    }
}
