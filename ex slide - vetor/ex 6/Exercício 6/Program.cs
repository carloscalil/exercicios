using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 0, p = 0, o = 0, j = 0;
            int[] n = new int[10];
            int[] impar = new int[10];
            int[] par = new int[10];
            int i;

            for (i = 0; i <= 9; i++)
            {
                Console.Write("Digite o {0}º valor: ", i+1);
                n[i] = int.Parse(Console.ReadLine());                         
            }
            Console.WriteLine("---------------------------");
            for (i = 0; i <= 9; i++)
            {                
                Console.WriteLine("O {0}º valor digitado foi: {1}", i + 1, n[i]);
            }
            Console.WriteLine("");
            for (i = 0; i <= 9; i++)
            {
                if (n[i] % 2 == 0)
                {
                    
                    par[m] = n[i];
                    o = m;
                    m = m + 1;
                }
                else
                {
                    
                    impar[p] = n[i];
                    j = p;
                    p = p + 1;
                }
            }
            Console.WriteLine("");
            for (m = 0; m <= o; m++)
            {
                Console.WriteLine("{0} é par.",par[m]);               
            }
            Console.WriteLine("");
            for (p = 0; p <= j; p++)
            {
                Console.WriteLine("{0} é impar.",impar[p]);               
            }
            Console.ReadKey();
        }
    }
}
