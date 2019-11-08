using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_l
{
    class Program
    {
        static void Main(string[] args)
        {

            int l = 1, menor, maior;
            maior = 0;
            menor = 32767;

            while (l >= 0)
            {
                Console.Write("Digite o valor: ");
                l = int.Parse(Console.ReadLine());

                if (l > maior)
                {
                    maior = l;
                }
                if ((l < menor) && (l > 0))
                {
                    menor = l;
                }
            }
            Console.WriteLine("O menor valor inserido foi {0}", menor);
            Console.WriteLine("O maior valor inserido foi {0}", maior);
            Console.ReadKey();
        }
    }
}
