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
            double dolar, real, cotacao;

            Console.Write("Digite o valor em dolar: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("DIgite o valor atual da cotação do dolar: ");
            cotacao = double.Parse(Console.ReadLine());

            real = dolar / cotacao;

            Console.WriteLine();
            Console.WriteLine("O valor em reais será: {0:#.#,#}", real);
            Console.ReadKey();
        }
    }
}
