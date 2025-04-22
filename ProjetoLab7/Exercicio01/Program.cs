/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 20/04/2025 (domingo)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
        Random random = new Random();
        int[] vetor = new int[20];

        // Gerando vetor com números aleatórios entre 0 e 10
        Console.WriteLine("Vetor gerado:");
        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = random.Next(0, 11); 
            Console.Write(vetor[i] + " ");
        }

        Console.WriteLine("\n\nDigite um número entre 0 e 10 para buscar no vetor:");
        int x;
        while (!int.TryParse(Console.ReadLine(), out x) || x < 0 || x > 10)
        {
            Console.WriteLine("Entrada inválida. Digite um número entre 0 e 10:");
        }

        // Menor e maior valor do vetor
        int menor = vetor[0];
        int maior = vetor[0];
        foreach (int num in vetor)
        {
            if (num < menor) menor = num;
            if (num > maior) maior = num;
        }

        Console.WriteLine($"\n1. Menor valor do vetor: {menor}");
        Console.WriteLine($"   Maior valor do vetor: {maior}");

        // Primeira ocorrência de x
        int primeiraOcorrencia = -1;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == x)
            {
                primeiraOcorrencia = i;
                break;
            }
        }

        if (primeiraOcorrencia != -1)
            Console.WriteLine($"2. Primeira ocorrência de {x} está na posição: {primeiraOcorrencia}");
        else
            Console.WriteLine($"2. O número {x} não foi encontrado no vetor.");

        // Todas as ocorrências de x
        Console.Write("3. Todas as posições de ocorrência de x: ");
        bool encontrou = false;
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] == x)
            {
                Console.Write(i + " ");
                encontrou = true;
            }
        }
        if (!encontrou)
            Console.Write("Nenhuma ocorrência encontrada.");
        Console.WriteLine();

        // Número de ocorrências
        int contador = 0;
        foreach (int num in vetor)
        {
            if (num == x) contador++;
        }
        Console.WriteLine($"4. O número {x} apareceu {contador} vez(es) no vetor.");
    }
  }
}