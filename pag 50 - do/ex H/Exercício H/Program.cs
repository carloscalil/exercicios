using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_H
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, resposta;
            int i = 1;
            double largura, comprimento, area, total=0;

            do
            {
                Console.Write("Digite o nome do cômodo: ");
                nome = Console.ReadLine();
                Console.Write("Digite a largura do cômodo: ");
                largura = double.Parse(Console.ReadLine());
                Console.Write("Digite o comprimento do cômodo: ");
                comprimento = double.Parse(Console.ReadLine());

                area = largura * comprimento;
                total = total + area;
               

                Console.WriteLine();
                Console.WriteLine("A área do cômodo chamado {0} é: {1}", nome, area);
                Console.WriteLine();
                Console.Write("Deseja colocar mais cômodos? Digite SIM ou NAO: ");
                resposta = Console.ReadLine();
                Console.WriteLine();
                
            } while (resposta != "NAO");
            Console.WriteLine();
            Console.WriteLine("O valor total das áreas é: {0}", total);
            Console.ReadKey();
        }
    }
}
