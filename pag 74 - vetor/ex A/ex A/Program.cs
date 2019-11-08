using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a) Ler 10 elementos de uma matriz tipo vetor e apresentá-los. */
            double[] vetor=new double[10]; 
            int i;

            for (i=0;i<=9; i++)
            {
                Console.WriteLine("Digite um valor: ");
                vetor[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 9; i++)
            {


                Console.WriteLine("O {0}° elemento é {1}", i + 1, vetor[i]);
            }
            Console.ReadKey();
        }
    }
}
