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
            double aux;
            int i=0;
            int cont=0;

            while (cont <= 5)
            {
                Console.Write("Digite um valor para A: ");
                aux = double.Parse(Console.ReadLine());
                if ((aux % 2) == 0)
                {
                    A[i] = aux;
                    cont++;
                }
                
            }
            while ((cont >= 6) && (cont <= 11))
            {
                Console.Write("Digite um valor para B: ");
                aux = double.Parse(Console.ReadLine());
                if ((aux % 2) == 1)
                {
                    B[i] = aux;
                    cont++;
                }
                            }
            Console.WriteLine("-------------------------------------");
            for (cont = 0; cont <= 11; cont++)
            {
                if (cont <= 5)
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i];
                }
                Console.WriteLine("O {0}º valor de C: {1}", cont + 1, C[i]);
            }
            
            Console.ReadKey();

        }
    }
}
