/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 17/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace VetorInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetorOriginal = new int[10];
            int[] vetorInvertido = new int[10];

            // Leitura dos 10 números
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Digite o {i + 1}º número: ");
                vetorOriginal[i] = int.Parse(Console.ReadLine());
            }

            // Criação do vetor invertido
            for (int i = 0; i < 10; i++)
            {
                vetorInvertido[i] = vetorOriginal[9 - i];
            }

            // Exibição dos vetores
            Console.WriteLine("\nVetor Original:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetorOriginal[i] + " ");
            }

            Console.WriteLine("\nVetor Invertido:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(vetorInvertido[i] + " ");
            }

            Console.WriteLine("\nFim do programa.");
        }
    }
}
