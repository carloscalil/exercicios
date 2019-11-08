using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler 8 elementos em uma matriz A tipo vetor. Construir uma matriz B de mesma dimensão com os
            elementos da matriz A multiplicados 5. Montar uma rotina de pesquisa seqüencial, para pesquisar
            os elementos armazenados na matriz B.*/

            int[] a = new int[8];
            int[] b = new int[8];
            int i, j, comeco, final, meio = 0, pesq, x;
            string resp = "sim";
            bool acha;


            for (i = 0; i < 8; i++)
            {
                Console.WriteLine("Digite um numero: ");
                a[i] = int.Parse(Console.ReadLine());
                b[i] = a[i] * 5;
            }
            for (i = 0; i < 7; i++)
            {
                for (j = i + 1; j < 8; j++)
                {
                    if (b[i] > b[j])
                    {
                        x = b[i];
                        b[i] = b[j];
                        b[j] = x;
                    }
                }
                //pesquisa
                while (resp == "sim")
                {
                    Console.Write("Digite o numero que deseja pesquisar: ");
                    pesq = int.Parse(Console.ReadLine());
                    comeco = 0;
                    final = 7;
                    acha = false;

                    while ((comeco <= final) && (acha == false))
                    {
                        meio = (comeco + final) / 2;
                        if (pesq == b[meio])
                        {
                            acha = true;
                        }
                        else
                        {
                            if (pesq < b[meio])
                            {
                                final = meio - 1;
                            }
                            else
                            {
                                comeco = meio + 1;
                            }
                        }
                    }
                    if (acha == true)
                    {
                        Console.WriteLine("{0} - Foi encontrado na posiçao {1}", pesq, meio + 1);
                    }
                    else
                    {
                        Console.WriteLine("{0} - Nao foi localizado", pesq);
                    }
                    Console.WriteLine("Deseja continuar [sim/nao?");
                    resp = Console.ReadLine();

                }
                Console.ReadKey();
            }
        }
    }
}