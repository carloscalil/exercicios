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
            int valor, cont=1, fatorial=1, contf =1;
            double soma = 0;

            do
            {
                Console.Write("Digite o {0}º valor inteiro: ", cont);
                valor = int.Parse(Console.ReadLine());

                do
                {
                    fatorial = fatorial * contf;
                    contf++;
                } while (contf <= valor);
                soma = soma + fatorial;
                fatorial = 1;
                contf = 1;
                               
                cont++;
            } while (cont <= 15);
            Console.WriteLine();
            Console.WriteLine("O valor da soma dos fatorias é: {0}", soma);
            Console.ReadKey();
        }
    }
}
