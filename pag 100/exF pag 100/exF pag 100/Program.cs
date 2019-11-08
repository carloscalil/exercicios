using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exF_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler uma matriz A de duas dimensões com 7 linhas e 7 colunas.
             * Construir uma matriz B de mesma dimensão, sendo que cada elemento da matriz B 
             * deverá ser o somatório de cada elemento correspondente da matriz A com o os seus índices 
             * (ou seja, se A[1,2] possui o valor 8, B[1,2] deverá possuir o valor 11, correspondente a 8+1+2),
             * com exceção para os valores situados nos índices ímpares da diagonal principal (B[1,1], B[3,3] , B[5,5] , B[7,7]), 
             * os quais deverão ser o fatorial de cada elemento correspondente da matriz A. Apresentar ao final a matriz A e B lado a lado. */

            double[,] a = new double[7, 7];
            double[,] b = new double[7, 7];
            int i, j, fatorial;

            for (i = 1; i < 4; i++)
            {
                for (j = 1; j < 4; j++)
                {
                    Console.Write("Digite o elemento [{0} - {1}] da matriz A: ", i, j);
                    a[i, j] = double.Parse(Console.ReadLine());
                    b[i, j] = a[i, j] + i + j;
                }
            }
            if ((i %2==1) && (j%2==1) && (i = j))
            {
                for
                    { b[i, j] =
            }


            for (i = 1; i < 4; i++)
            {
                for (j = 1; j < 4; j++)
                {
                    Console.WriteLine("O elemento [{0} - {1}] da matriz B: {2} ", i, j,b[i, j]);
                }
            }
            Console.ReadKey();

                
        }
    }
}
