using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_E
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, taxa, tempo, prestacao;

            Console.Write("Digite o valor em atraso (reais): ");
            valor = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor da taxa (reais): ");
            taxa = float.Parse(Console.ReadLine());
            Console.Write("Digite o valor dos meses em atraso: ");
            tempo = float.Parse(Console.ReadLine());

            prestacao = valor + (valor * taxa / 100) * tempo;

            Console.WriteLine();
            Console.Write("O valor da prestacao será: {0} reais", prestacao);
            Console.ReadKey(); 

        }
    }
}
