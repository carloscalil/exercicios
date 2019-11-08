using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_J
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 50, soma = 0, media = 0, cont2=1;
            Console.Write("Faixa numérica de 50 a 70.");
            Console.WriteLine();
            Console.WriteLine();

            while (cont <= 70)
            {
                if (cont % 2 == 0)
                {
                    soma = soma + cont;
                    cont2++;
                }
                cont++;
            }
            media = soma / (cont2 - 1) ;

            Console.WriteLine("A soma será: {0}", soma);
            Console.WriteLine("A média será: {0}", media);

            Console.ReadLine();
        }
    }
}
