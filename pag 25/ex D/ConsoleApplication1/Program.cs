using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo, velocidade, distancia;

            Console.Write("Digite o tempo da viagem (Horas): ");
            tempo = float.Parse(Console.ReadLine());
            Console.Write("Digite a velocidade media (Km/h): ");
            velocidade = float.Parse(Console.ReadLine());

            distancia = tempo*velocidade;

            Console.WriteLine();
            Console.Write("A distancia percorrida foi de: {0} Km", distancia);
            Console.ReadKey();
        }
    }
}
