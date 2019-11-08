using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioA
{
    class Program
    {
        static void Main(string[] args)
        {

            float c, f;

            Console.Write("Digite a temperatura em Fahrenheit: ");
            f = float.Parse(Console.ReadLine());

            c = (f-32)*5/9;

            Console.Write("Os graus em Celsius será: {0}", c);
            Console.ReadLine();

        }
    }
}
