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
            int a;

            Console.Write("Entre com um valor inteiro: ");
            a = int.Parse(Console.ReadLine());

            if (a<0)
            {
                a = a * (-1);
            }

            Console.Write("O módulo do valor inteiro será: {0}", a);
            Console.ReadKey();
        }
    }
}
