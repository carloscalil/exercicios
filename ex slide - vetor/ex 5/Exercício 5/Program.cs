using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet1 = new int[5];
            int[] vet2 = new int[5];
            int[] soma = new int[5];
            int[] diferenca = new int[5];
            int[] produto = new int[5];
            int[] divisao = new int[5];
            int i;

            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º valor do grupo 1: ", i+1);
                vet1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 4; i++)
            {
                Console.Write("Digite o {0}º valor do grupo 2: ", i+1);
                vet2[i]= int.Parse(Console.ReadLine());
            }
            Console.WriteLine("---------------------------------");
            for (i = 0; i <= 4; i++)
            {
                soma[i] = vet1[i] + vet2[i];
                diferenca[i] = vet1[i] - vet2[i];
                produto[i] = vet1[i] * vet2[i];
                divisao[i] = vet1[i] / vet2[i];

                Console.WriteLine("A soma dos {0}ºs valores é: {1}", i + 1, soma[i]);
                Console.WriteLine("A diferença dos {0}ºs valores é: {1}", i + 1, diferenca[i]);
                Console.WriteLine("O produto dos {0}ºs valores é: {1}", i + 1, produto[i]);
                Console.WriteLine("A divisão dos {0}ºs valores é: {1}", i + 1, divisao[i]);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
