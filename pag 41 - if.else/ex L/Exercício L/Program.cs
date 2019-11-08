using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_L
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, sexo;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o seu sexo (F ou M): ");
            sexo = Console.ReadLine();

            if (sexo == "F")
            {
                Console.WriteLine("====================");
                Console.WriteLine("Ilma Sra. {0}", nome);
            }
            else
            {
                if (sexo == "M")
                {
                    Console.WriteLine("====================");
                    Console.WriteLine("Ilmo Sr. {0}", nome);
                }
                else
                {
                    Console.WriteLine("=========================");
                    Console.WriteLine("Letra para sexo inválida.");
                }
            }
            Console.ReadKey();
        }
    }
}
