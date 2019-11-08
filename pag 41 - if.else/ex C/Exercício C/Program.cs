using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_C
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, media;

            Console.Write("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.Write("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.Write("Digite a quarta nota: ");
            n4 = float.Parse(Console.ReadLine());

            media = (n1 + n2 + n3 + n4) / 4;

            if (media >= 5)
            {
                Console.WriteLine("O aluno foi aprovado!");
                Console.WriteLine("A média do aluno é: {0}", media);
            }

            else
            { 
                Console.WriteLine("O aluno foi reporvado!");
                Console.WriteLine("A média do aluno é: {0}",media);
            }

            Console.ReadKey();
        }
    }
}
