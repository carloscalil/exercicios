using System;

namespace ex_K
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler duas matrizes A e B de uma dimensão com 6 elementos.A matriz A deverá aceitar apenas a entrada 
            de valores pares, enquanto a matriz B deverá aceitar apenas a entrada de valores ímpares.
            A entrada das matrizes deverá ser validada pelo programa e não pelo usuário. Construir uma matriz
            C de forma que a matriz C seja a junção das matrizes A e B, de modo que a matriz C contenha 12
            elementos. Apresentar a matriz C.*/

            double[] A = new double[6];
            double[] B = new double[6];
            double[] C = new double[12];
            int i;

            for (i = 0; i <= 5; i++)
            {
                Console.Write("Digite um valor para A: ");
                A[i] = double.Parse(Console.ReadLine());
                while ((A[i] % 2) == 1)
                {
                    Console.Write("O numero deve ser par. Digite outro valor: ");
                    A[i] = double.Parse(Console.ReadLine());
                }
                for (i = 0; i <= 5; i++)
                {
                    Console.Write("Digite um valor para B: ");
                    B[i] = double.Parse(Console.ReadLine());
                    while ((B[i] % 2) == 0)
                    {
                        Console.Write("O numero deve ser impar. Digite outro valor: ");
                        B[i] = double.Parse(Console.ReadLine());
                    }
                    for (i = 0; i <= 11; i++)
                    {
                        if (i <= 5)
                        {
                            C[i] = A[i];
                        }
                        else
                        {
                            C[i] = B[i];
                        }
                    }
                    Console.WriteLine("O {0}º valor de C: {1}", i + 1, C[i]);
                    Console.ReadKey();

                }
            }
        }
    }
}