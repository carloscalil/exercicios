using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_I
{
    class Program
    {
        static void Main(string[] args)
        {
            double cont = 1, valor=0, soma=0, media=0;

            while (cont <= 10)
            {
                Console.Write("Digite o {0}º valor: ", cont);
                valor = double.Parse(Console.ReadLine());

                soma = soma + valor;
                cont++;
            }
            media = soma / (cont - 1);

            Console.WriteLine("A soma será: {0}", soma);
            Console.WriteLine("A média será: {0}", media);
            Console.ReadKey();
        }
    }
}
