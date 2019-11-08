using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, soma=0;
            int i;
            double[] md = new double[8]; //são 8 elementos, mas o c# sempre começa no zero, por isso colocou o 7.

            for(i = 0; i <= 7; i++)
            {
                Console.Write("Digite a {0}ª nota: ", i + 1);
                md[i] = double.Parse(Console.ReadLine());
                soma = soma + md[i];
            }
            for (i = 0; i <= 7; i++)
            {
                Console.WriteLine("A {0}ª nota: {1}", i + 1, md[i]);
            }
            media = soma / 8;
            Console.Write("A média é: {0}", media);
            Console.ReadKey();
        }
    }
}
