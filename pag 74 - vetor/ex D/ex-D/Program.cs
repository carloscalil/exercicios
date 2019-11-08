using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_D
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler 15 elementos de uma matriz tipo vetor. Construir uma matriz B de mesmo tipo, observando a
     seguintes lei de formação: “Todo elemento de B deverá ser o quadrado do elemento de A
     correspondente”. Apresentar as matrizes A e B.*/

            double[] a = new double[15];
            double[] b = new double[15];
            int i;

            for (i = 0; i <= 14; i++)
            {
                Console.WriteLine("Insira o {0}º valor de A: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 14; i++)
            {
                Console.WriteLine("O {0}º valor do vetor A é: {1}", i + 1, a[i]);
            }

            for (i = 0; i <= 14; i++)
            {
                b[i] = Math.Pow(a[i], 2);
                
                Console.WriteLine("O {0}º valor do vetor B é: {1}",i + 1,b[i]);                
            }
            Console.ReadKey();
        }
    }
}
