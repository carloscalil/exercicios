using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo___Ordenar_automático
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int x;
            for(int i = 0; i < 5; i++)
            {
                Console.Write("Digite um numero: ");
                num[i] = int.Parse(Console.ReadLine());
            }
            for(int i = 0; i < 4; i++)
            {
                for(int j = i + 1; j < 5; j++)
                {
                    if (num[i] > num[j])
                    {
                        x = num[i];
                        num[i] = num[j];
                        num[j] = x;
                    }
                }
            }
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0} - {1}", i, num[i]);
            }
            Console.ReadKey();
        }
    }
}
