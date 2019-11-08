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
            int cont;

            for (cont=1; cont<200; cont++)
            {
                if (cont % 4 == 0)
                {
                    Console.WriteLine("{0}", cont);
                }
            }
            Console.ReadLine();
        }
    } 
}
