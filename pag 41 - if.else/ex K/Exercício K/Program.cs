using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_K
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.Write("Digite um valor: ");
            a = int.Parse(Console.ReadLine());

            if (!(a>3))
            {
                Console.WriteLine("=================================");
                Console.WriteLine("O valor {0} não é maior do que 3.", a);
            }
            Console.ReadKey();           
        }
    }
}
