using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exAp100
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler duas matrizes A e B, cada uma de duas dimensões com 5 linhas e 3 colunas. Construir uma matriz C de mesma dimensão, 
             * que é formada pela soma dos elementos da matriz A com os elementos da matriz B. Apresentar a matriz C.*/

            double[,] a = new double[5, 3];
            double[,] b = new double[5, 3];
            double[,] c = new double[5, 3];
            int j, i;

            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Digite o elemento {0} - {1} ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Digite o elemento {0} - {1} ", i + 1, j + 1);
                    b[i, j] = double.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                    Console.WriteLine("O elemento [{0},{1}] é {2}", i + 1, j + 1, c[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
