using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faca um programa q pergunte ao usuário o numero de alunos a ser lido. 
             * O tamanho dos vetores será o numero informado pelo usuário. Armazene num 
             * vetor as notas G1 destes alunos; num outro vetor, armazene as notas G2 destes 
             * alunos. Ambas notas, G1 e G2, são informadas pelo usuário. Calcule a media 
             * aritmética destes alunos e armazene num terceiro vetor. Ao final, mostre as 
             * 3 notas dos alunos. */

            int n;
            Console.Write("Digite a quantidade de alunos: ");
            n = int.Parse(Console.ReadLine());

            double[] g1 = new double[n];
            double[] g2 = new double[n];
            double[] media = new double[n];
            int i;

            for (i = 0; i <= (n - 1); i++)
            {
                Console.Write("Digite a no G1 do {0}º aluno: ", i + 1);
                g1[i] = double.Parse(Console.ReadLine());
                Console.Write("Digite a no G2 do {0}º aluno: ", i + 1);

                g2[i] = double.Parse(Console.ReadLine());

                media[i] = (g1[i] + g2[i]) / 2;
            }
            Console.WriteLine("-------------------------------------------" +
                "");
            for (i = 0; i <= (n - 1); i++)
            {
                Console.WriteLine("{0}º aluno - G1 = {1}, G2 = {2} e a média = {3}.", i + 1, g1[i], g2[i], media[i]);
            }
            Console.ReadKey();
        }
    }
}
