using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_C
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler duas matrizes A e B do tipo vetor com 20 elementos. Construir uma matriz C, onde cada
            //elemento de C é a subtração do elemento correspondente de A com B.Apresentar a matriz C

            double[] a = new double[20];
            double[] b = new double[20];
            double[] c = new double[20];
            int i;

            for(i=0;i<=19;i++){
                Console.WriteLine("Insira o {0}° valor de A: ",i+1);
                a[i] = double.Parse(Console.ReadLine()); 
            }
            for (i = 0; i <= 19; i++)
            {
                Console.WriteLine("Insira o {0}° valor de B: ", i + 1);
                b[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 19; i++)
            {
                c[i] = a[i] - b[i];
                Console.WriteLine("O {0}º de valor de C é: {1}",i+1,c[i]);
               
            }
            Console.ReadKey();


        }
    }
}
