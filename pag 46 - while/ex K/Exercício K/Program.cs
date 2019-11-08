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
            string nome="a", resposta="SIM";
            double largura, comprimento, area=0, areaT=0;

            Console.Write("Cálculo da área da casa.");
            Console.WriteLine();
            Console.WriteLine();

            while (resposta == "SIM")
            {
                Console.Write("Escreva o nome do comodo: ");
                nome = Console.ReadLine();
                Console.Write("Digite a largura do comodo: ");
                largura = double.Parse(Console.ReadLine());
                Console.Write("Digite o comprimento do comodo: ");
                comprimento = double.Parse(Console.ReadLine());

                area = largura * comprimento;
                areaT = areaT + area;

                Console.WriteLine("A área do comodo é: {0}", area);
                Console.WriteLine();

                Console.Write("Digite SIM para colocar mais comodos: ");
                resposta = Console.ReadLine();
                Console.WriteLine();

            }
            Console.WriteLine("A área total da casa é: {0}", areaT);
            Console.ReadKey();
        }
    }
}
