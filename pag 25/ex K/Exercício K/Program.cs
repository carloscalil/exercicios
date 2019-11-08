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

            Console.Write("Digite o valor em reais: ");
            real = double.Parse(Console.ReadLine());
            Console.Write("DIgite o valor atual da cotação do dolar: ");
            cotacao = double.Parse(Console.ReadLine());

            dolar = real * cotacao;

            Console.WriteLine();
            Console.WriteLine("O valor em dolar será: {0:#.#,#}", dolar);
            Console.ReadKey();
        }
    }
}
