using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_H
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont=1, c, f;

            Console.Write("As temperaturas de Celsius de 10 em 10 sendo convertidas em Fahrenheit.");
            Console.WriteLine();
            Console.WriteLine();

            while (cont <= 10)
            {
                c = 10 * cont;
                f = (9 * c + 160) / 5;

                Console.WriteLine("{0} Celsius = {1} Fahrenheit", c, f);

                cont++;
            }
            Console.ReadKey();
        }
    }
}
