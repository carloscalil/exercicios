using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_C
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont, soma=0;

            for (cont=1; cont <=100; cont++)
            {
                soma = soma + cont;                
            }
            Console.WriteLine("{0}", soma);
            Console.ReadKey();
        }
    }
}
