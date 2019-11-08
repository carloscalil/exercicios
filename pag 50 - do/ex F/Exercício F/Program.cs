using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_F
{
    class Program
    {
        static void Main(string[] args)
        {
            float valor, soma=0, i=0;
            float media = 0;

            do
            {
                Console.Write("Digite o valor: ");
                valor = float.Parse(Console.ReadLine());

                if (valor >= 0)
                {
                    soma = soma + valor;
                    i++;
                }
                
            } while (valor >= 0);
            
            media = soma / i;

            Console.WriteLine();
            Console.WriteLine("O valor total é: {0}", soma);
            Console.WriteLine("O valor da média é: {0}", media);
            Console.WriteLine("O total dos valores válidos inseridos foram: {0}", i);
            Console.ReadKey();
        }
    }
}
