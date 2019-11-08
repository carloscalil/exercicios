using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exC_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler 20 elementos para uma matriz qualquer, considerando que ela tenha o tamanho de 4 linhas por 5 colunas, em seguida apresentar a matriz. */

            double [,]a = new double [4, 5];
            int i, j;

            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.Write("Digite o elemento {0} - {1}: ", i + 1, j + 1);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (i = 0; i < 4; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("O elemento [{0},{1}] da matriz A é: {2}", i + 1, j + 1, a[i, j]);
                }
            }
            Console.ReadKey();
        }
    }
}
