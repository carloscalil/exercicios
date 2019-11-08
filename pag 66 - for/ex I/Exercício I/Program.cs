using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_I
{
    class Program
    {
        static void Main(string[] args)
        {
            int atual=1, anterior = 0, resultado = 0, cont;

            for (cont = 1; cont <= 15; cont++)
            {
                resultado = anterior + atual;
                Console.WriteLine("{0}", atual);
                anterior = atual;
                atual = resultado;
            }
            Console.ReadKey();
        }
    }
}
