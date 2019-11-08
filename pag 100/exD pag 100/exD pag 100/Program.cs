using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exD_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ler uma matriz A de uma dimensão com 10 elementos. Construir uma matriz C de duas 
             * dimensões com três colunas, em que a primeira coluna da matriz C é formada pelos elementos da matriz 
             * A somados com mais 5, a segunda coluna é formada pelo valor do cálculo da fatorial de cada elemento 
             * correspondente da matriz A e a terceira e última coluna deverá ser formada  
             * pelos quadrados dos elementos correspondentes da matriz A. Apresentar a matriz C. (
             * Observe que fatorial de zero é igual a 1.) */

            double[] a = new double[10];
            double[,] c = new double[11, 3];
            int i,j;

            for (i = 0; i < 10; i++)
            {
                Console.Write("Digite o {0}° valor de A: ", i + 1);
                a[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i < 10; i++)
            {
                c[i, 0] = a[i] + 5;
                c[i,1] = 1;
                for (j = 1; j <= a[i]; j++)
                {
                    
                    c[i, 1] = c[i, 1] * j;
                }
                c[i, 2] = Math.Pow(a[i], 2);   
            }
            
            
            for (i = 0; i < 10; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("O elemento [{0} - {1}] da matriz C eh: {2}",i+1,j+1,c[i,j]);
                }
                        
            }
            Console.ReadKey();
        }
        
    }
}
