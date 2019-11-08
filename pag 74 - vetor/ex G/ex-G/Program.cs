using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_G
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler 20 elementos de uma matriz A tipo vetor e construir uma matriz B de mesma dimensão com os
            mesmo elementos da matriz A, sendo que deverão estar invertidos. Ou seja, o primeiro elemento de
            A passa a ser o último de B, o segundo elemento de A passa a ser o penúltimo elemento de B e
            assim por diante. Apresentar as matrizes A e B lado a lado. */

            double[] A = new double[20];            double[] B = new double[20];
            int i;

            for (i = 0; i <= 19; i++)
            {
                Console.Write("Insira o {0}° de A: ", i + 1);
                A[i] = double.Parse(Console.ReadLine());
                B[19 - i] = A[i];
            }
            for (i = 0; i <= 19; i++)
            {
                Console.WriteLine("{0} , {1}", A[i], B[i]);
            }
            
            Console.ReadKey();
        }
        }
}
