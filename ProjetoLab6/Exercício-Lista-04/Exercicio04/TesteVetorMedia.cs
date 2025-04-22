/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 17/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace TesteVetorMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas;
            double media = 0, soma = 0, menor = 0, maior = 0;
            int i = 0;

            notas = new double[5];

            for (i = 0; i < 5; i++)
            {
                Console.Write("\nDigite a nota {0}: ", i);
                notas[i] = double.Parse(Console.ReadLine());
            }

            menor = notas[0];
            maior = notas[0];

            // Cálculo da soma, menor e maior nota
            for (i = 0; i < 5; i++)
            {
                soma += notas[i];

                if (notas[i] < menor)
                {
                    menor = notas[i];
                }

                if (notas[i] > maior)
                {
                    maior = notas[i];
                }
            }

            media = soma / 5;

            Console.WriteLine("\nSoma total = {0}", soma);
            Console.WriteLine("\nMédia = {0}", media);
            Console.WriteLine("\nMenor nota = {0}", menor);
            Console.WriteLine("\nMaior nota = {0}", maior);
            Console.WriteLine("\t\tFim do programa ");
            Console.ReadKey();
        }
    }
}

