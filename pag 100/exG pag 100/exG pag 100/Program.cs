using System;

namespace exG_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler uma matriz A de duas dimensões com 4 linhas e 4 colunas. Ao final apresentar o total de
            elementos pares existentes dentro da matriz. (Observe que é o total de Elementos e não a soma
            total do conteúdo dos elementos.)*/

            double[,] a = new double[4, 4];
            int i, j, total=0;

            for (i=0; i < 4; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("Digite o elemento [{0} - {1}] da matriz A: ",i+1,j+1);
                    a[i, j] = double.Parse(Console.ReadLine());
                    if (a[i, j] % 2 == 0)
                    {
                        total = total + 1;
                    }
                }
            }
            Console.Write("O total de elementos pares eh: {0}", total);
        }
    }
}
