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
            double a, b, c, d, e, maior, menor;
            menor = 0;
            maior = 0;

            Console.Write("Digite o primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            c = double.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            d = double.Parse(Console.ReadLine());
            Console.Write("Digite o quinto valor: ");
            e = double.Parse(Console.ReadLine());

            if ((a > b) && (a > c) && (a > d) && (a > e))
            {
                maior = a;
            }
            else
            {
                if ((b > a) && (b > c) && (b > d) && (b > e))
                {
                    maior = b;
                }
                else
                {
                    if ((c > b) && (c > a) && (c > d) && (c > e))
                    {
                        maior = c;
                    }
                    else
                    {
                        if ((d > b) && (d > c) && (d > a) && (d > e))
                        {
                            maior = d;
                        }
                        else
                        {
                            maior = e;
                        }
                    }

                }
                if ((a < b) && (a < c) && (a < d) && (a < e))
                {
                    menor = a;
                }
                else
                {
                    if ((b < a) && (b < c) && (b < d) && (b < e))
                    {
                        menor = b;
                    }

                    else
                    {
                        if ((c < b) && (c < a) && (c < d) && (c < e))
                        {
                            menor = c;
                        }
                        else
                        {
                            if ((d < b) && (d < c) && (d < a) && (d < e))
                            {
                                menor = d;
                            }
                            else
                            {
                                menor = e;
                            }
                        }

                    }
                }
                Console.WriteLine("===========================================");
                Console.WriteLine("O maior valor é {0} e o menor valor é {1}.", maior, menor);
                Console.ReadKey();
            }
        }
    }
}
