using System;

namespace exH_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler uma matriz A de duas dimensões com 10 linhas e 7 colunas. Ao final apresentar o total de
            elementos pares e o total de elementos ímpares existentes dentro da matriz. Apresentar também o
            percentual de elementos pares e ímpares em relação ao total de elementos da matriz. Supondo a
            existência de 20 elementos pares e 50 elementos ímpares, ter-se-ia 28.6 % de elementos pares e
            71,4% de elementos ímpares.*/

            double[,] a = new double[10, 7];
            int i, j,Tpar=0,Timpar=0, Pimpar, Ppar;

            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 7; j++)
                {
                    Console.Write("Digite o elemento [{0} - {1}] da matriz A: ", i + 1, j + 1);
                    a[i, j] = double.Parse(Console.ReadLine());
                    if (a[i, j] % 2 == 0)
                    {
                        Tpar = Tpar + 1;
                    }
                    else
                    {
                        Timpar = Timpar + 1;
                    }
                }
            }
            Pimpar = 70 - Tpar;
            Pimpar = Pimpar * 100 / 70;
            Ppar = 100 - Pimpar;
            Console.WriteLine("O total de elementos pares sao: {0}", Tpar);
            Console.WriteLine("O total de elementos impares sao: {0}", Timpar);
            Console.WriteLine("O percentutal de elementos pares sao: {0}", Ppar);
            Console.WriteLine("O percentual de elementos pares sao: {0}", Pimpar);
            Console.ReadKey();
        }
    }
}
