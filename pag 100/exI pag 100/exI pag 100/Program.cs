using System;

namespace exI_pag_100
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolver um programa que efetua a leitura dos nomes de 5 alunos e também de suas duas
            notas semestrais. Ao final deverá ser apresentado o nome de cada aluno classificado em ordem
            numérica crescente de suas médias anuais.*/

            string[] nome = new string[5];
            int i, j;
            double[] n1 = new double[5];
            double[] n2 = new double[5];
            double aux;
            string auxNome;
            double[] media = new double[5];

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome do aluno:");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Digite a primeira nota do aluno:");
                n1[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a segunda nota do aluno:");
                n2[i] = double.Parse(Console.ReadLine());
                media[i] = (n1[i] + n2[i]) / 2;
            }
            for (i = 0; i < 4; i++)
            {
                for (j = i + 1; j < 5; j++)
                {
                    if (media[i] > media[j])
                    {
                        aux = media[i];
                        media[i] = media[j];
                        media[j] = aux;

                        auxNome = nome[i];
                        nome[i] = nome[j];
                        nome[j] = auxNome;
                    }
                }
            }
            Console.WriteLine("Classificacao de media:");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Aluno: {0} Media: {1}", nome[i], media[i]);
            }
            Console.ReadKey();
        }
    }
}
