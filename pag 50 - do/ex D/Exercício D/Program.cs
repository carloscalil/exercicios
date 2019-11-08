using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_D
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont=1, resultado=1;

            do
            {
                resultado = Math.Pow(resultado, 2);
                cont++;
            } while (cont <= 64);
            Console.WriteLine("{0}", resultado);
            Console.ReadKey();
        }
    }
}
