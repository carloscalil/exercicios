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
            int valor, aux, maior=0, menor=0, cont=1;

            do
            {
                Console.Write("Digite um valor: ");
                valor = int.Parse(Console.ReadLine());
                
                if(cont == 1)
                {
                    maior = valor;
                    menor = valor;
                }
                if (valor >= 0)
                {
                    aux = valor;
                    if (valor > maior)
                    {
                        maior = valor;
                    }
                    else
                    {
                        if (valor < menor)
                        {
                            menor = valor;
                        }
                    }
                }
                cont=0;
            } while (valor >= 0);
            Console.WriteLine();
            Console.WriteLine("O maior valor é {0} e o menor valor é {1}.", maior, menor);
            Console.ReadKey();
        }
    }
}
