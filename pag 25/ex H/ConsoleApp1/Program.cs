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
            double comprimento, largura, altura, volume;

            Console.Write("Digite o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());
            Console.Write("Digite a largura: ");
            largura = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = double.Parse(Console.ReadLine());

            volume = comprimento * largura * altura;

            Console.WriteLine();
            Console.WriteLine("O volume será: {0}", volume);
            Console.ReadKey();
               
        }
    }
}
