using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exE_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler uma matriz A de duas dimensões com 10 linhas e 10 colunas. Apresentar 
             * o somatório dos elementos situados na diagonal principal (posições A[1,1], A[2,2], A[3,3], A[4,4]
             * e assim por diante) da referida matriz. 
             * (Claro que não é para efetuar a soma deste modo: SOMA <- A[1,1] + A[2,2] + A[3,3] + ... + A[10,10]) */

            double[,] a = new double[10, 10];
            int i, j;
            double soma = 0;

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("Digite o elemento {0} - {1}: ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                    soma = soma + a[i + 1, j + 1];
                }
            }
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (i = j)
                    {
                        soma = soma + a[i + 1, j + 1];
                    }
                }
            }
            Console.Write("A valor da soma é: {0}", soma);
            Console.ReadKey();
        }

    }
}
