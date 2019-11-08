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
            double v, r, h;

            Console.Write("Digite o valor do raio: ");
            r = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da altura: ");
            h = float.Parse(Console.ReadLine());

            v = Math.PI * Math.Pow(r,2) * h;

            Console.Write("O valor do volume é: {0:#.#,#}", v);
            Console.ReadKey();
        
        }
    }
}
