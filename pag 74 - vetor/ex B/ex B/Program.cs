using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_B
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ler 8 elementos em uma matriz A tipo vetor. Construir uma matriz B de mesma dimensão com os
elementos da matriz A multiplicados por 3. O elemento B[i] deverá ser implicado pelo elemento
A[i]*3, o elemento B[2] implicado pelo elemento A[2]*3 e assim por diante, até 8. Apresentar o vetor
B.*/
        double[] A = new double[8]; 
        double[] B = new double[8];
        int i;
        for (i = 0; i <= 8; i++);
            {
            Console.WriteLine("Digite um valor: ");
            A[i] = double.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 8; i++);
            {
                B[i] = A[i] * 3;
                Console.WriteLine("O vetor de B é; {0}", B[i]);


            }
            Console.ReadKey();
        }
    }
}
