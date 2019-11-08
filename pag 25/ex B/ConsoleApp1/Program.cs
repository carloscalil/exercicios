using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double c, f;

            Console.Write("Digite a temperatura em Fahrenheit: ");
            f = float.Parse(Console.ReadLine());

            c = (f - 32) * 5 / 9;

            Console.WriteLine();
            Console.WriteLine("A temperatura em celsius é: {0}", c);
            Console.ReadKey();
        }
    }
}
