using System;

namespace ex_J
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler 15 elementos reais para uma matriz A de uma dimensão do tipo vetor. Construir uma matriz B
            de mesmo tipo e dimensão, observando a seguinte lei de formação: “Todo elemento da matriz A
            que possuir índice par deverá ter seu elemento dividido por 2; caso contrário, o elemento da matriz
            A deverá ser multiplicado por 1.5”. Apresentar as matrizes A e B lado a lado.*/
            double[] A = new double[15];
            double[] B = new double[15];
            int i;

            for (i = 0; i <= 14; i++)
            {
                Console.Write("Digite o {0}º de A: ", i + 1);
                A[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 14; i++)
            {
                if ((A[i]%2) == 0)
                {
                    B[i] = A[i] / 2;
                }
                else
                {
                    B[i] = A[i] * 1.5;
                }
                Console.WriteLine("{0} - {1}", A[i], B[i]);
            }
            Console.ReadKey();
        }
    }
}
