using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_G
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatorial = 1, cont = 1, contf = 1;

            do
            {
                if (cont % 2 != 0)
                {
                    do
                    {
                        fatorial = fatorial * contf;
                        contf++;
                    } while (contf <= cont);
                    Console.WriteLine("O valor do fatorial de {0} é: {1}", cont, fatorial);
                    fatorial = 1;
                    contf = 1;
                }
                cont++;
            } while (cont <= 10);
            Console.ReadKey();
        }
    }
}
