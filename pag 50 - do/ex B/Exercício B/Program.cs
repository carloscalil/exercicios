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
            int soma=0, cont=1;

            do
            {
                if (cont % 2 == 0)
                {
                    soma = soma + cont;
                }
                cont++;
            } while (cont <= 500);
            Console.WriteLine("{0}", soma);
            Console.ReadKey();
        }
    }
}
