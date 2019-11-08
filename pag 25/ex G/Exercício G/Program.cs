using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_G
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, s1, s2, s3, s4, s5, s6, m1, m2, m3, m4, m5, m6;

            Console.Write("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: ");
            d = double.Parse(Console.ReadLine());

            s1 = a + b;
            s2 = a + c;
            s3 = a + d;
            s4 = b + c;
            s5 = b + d;
            s6 = c + d;
            m1 = a * b;
            m2 = a * c;
            m3 = a * d;
            m4 = b * c;
            m5 = b * d;
            m6 = c * d;

            Console.WriteLine("O valor da soma de A com B será: {0}", s1);
            Console.WriteLine("O valor da soma de A com C será: {0}", s2);
            Console.WriteLine("O valor da soma de A com D será: {0}", s3);
            Console.WriteLine("O valor da soma de B com C será: {0}", s4);
            Console.WriteLine("O valor da soma de B com D será: {0}", s5);
            Console.WriteLine("O valor da soma de C com D será: {0}", s6);
            Console.WriteLine("O valor da multiplicação de A com B será: {0}", m1);
            Console.WriteLine("O valor da multiplicação de A com B será: {0}", m2);
            Console.WriteLine("O valor da multiplicação de A com B será: {0}", m3);
            Console.WriteLine("O valor da multiplicação de A com B será: {0}", m4);
            Console.WriteLine("O valor da multiplicação de A com B será: {0}", m5);
            Console.WriteLine("O valor da multiplicação de A com B será: {0}", m6);

        }
    }
}
