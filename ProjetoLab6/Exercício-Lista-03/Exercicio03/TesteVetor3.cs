/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 17/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace TesteVetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas;
            double media = 0, soma = 0;
            notas = new double[5];
            int i = 0;

            for (i = 0; i < 5; i++)
            {
                Console.Write("\nDigite a nota {0}: ", i);
                notas[i] = double.Parse(Console.ReadLine());
            }

            // Cálculo da soma
            for (i = 0; i < 5; i++)
            {
                soma = soma + notas[i];
            }

            // Cálculo da média
            media = soma / 5;

            Console.WriteLine("\n\nSoma total = {0} ", soma);
            Console.WriteLine("\nMédia = {0} ", media);
            Console.WriteLine("\n\t\tFim do programa ");
            Console.ReadKey();
        }
    }
}
