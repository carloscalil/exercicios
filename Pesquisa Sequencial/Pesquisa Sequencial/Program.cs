using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesquisa_Sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nome = new string[10];
            int i;
            string pesq, resp = "sim";
            bool acha;

            for (i = 0; i <= 9; i++)
            {
                Console.Write("Digite o nome número {0}: ", i + 1);
                nome[i] = Console.ReadLine();
            }
            Console.WriteLine();
            while (resp == "sim")
            {
                Console.Write("Entre o nome a ser pesquisado: ");
                pesq = Console.ReadLine();

                acha = false;
                i = 0;
                while ((i <= 9) && (acha == false))
                {
                    if (pesq == nome[i])
                    {
                        acha = true;
                    }
                    else
                    {
                        i = i + 1;
                    }
                }
                if (acha == true)
                {
                    Console.WriteLine("{0}, foi localizado na posição {1}.", pesq, i + 1);
                }
                else
                {
                    Console.WriteLine("{0}, não foi localizado.", pesq);
                }
                Console.WriteLine();
                Console.Write("Deseja continuar? [sim/não] ");
                resp = Console.ReadLine();
            }
            Console.ReadKey();
           



        }
    }
}
