/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 17/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/

using System;

namespace IdadeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[40];
            int menor16 = 0, entre16e18 = 0, maior18 = 0;
            int soma = 0;
            int maisNovo, maisVelho;

            // Leitura das idades
            for (int i = 0; i < 40; i++)
            {
                Console.Write($"Digite a idade do aluno {i + 1}: ");
                idades[i] = int.Parse(Console.ReadLine());
                soma += idades[i];

                // Contagem por faixa etária
                if (idades[i] < 16)
                    menor16++;
                else if (idades[i] <= 18)
                    entre16e18++;
                else
                    maior18++;
            }

            // Inicializa o mais novo e o mais velho com o primeiro valor
            maisNovo = idades[0];
            maisVelho = idades[0];

            // Descobre o mais novo e o mais velho
            for (int i = 1; i < 40; i++)
            {
                if (idades[i] < maisNovo)
                    maisNovo = idades[i];
                if (idades[i] > maisVelho)
                    maisVelho = idades[i];
            }

            double media = (double)soma / 40;

            Console.WriteLine($"Total de alunos com menos de 16 anos: {menor16}");
            Console.WriteLine($"Total de alunos entre 16 e 18 anos: {entre16e18}");
            Console.WriteLine($"Total de alunos com mais de 18 anos: {maior18}");
            Console.WriteLine($"Média das idades: {media:F2}");
            Console.WriteLine($"Idade do aluno mais novo: {maisNovo}");
            Console.WriteLine($"Idade do aluno mais velho: {maisVelho}");
            Console.WriteLine("\n\tFim do programa.");
        }
    }
}
