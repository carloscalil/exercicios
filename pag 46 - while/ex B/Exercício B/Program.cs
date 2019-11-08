using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado=0, cont=1;

            Console.Write("Aperte qualquer letra para ver a soma dos 100 primeiros números inteiros.");
            Console.ReadKey();
            Console.WriteLine();

            while (cont <= 100)
            {
                resultado = resultado + cont;
                cont = cont + 1;
            }
            Console.WriteLine("Soma: {0}", resultado);
            Console.ReadKey();
        }
    }
}
