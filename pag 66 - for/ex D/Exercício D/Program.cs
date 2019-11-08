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
            int soma = 0, cont;

            for (cont=1; cont<=500; cont++)
            {
                if (cont % 2 == 0)
                {
                    soma = soma + cont;
                }
            }
            Console.WriteLine("{0}", soma);
            Console.ReadKey();
        }
    }
}
