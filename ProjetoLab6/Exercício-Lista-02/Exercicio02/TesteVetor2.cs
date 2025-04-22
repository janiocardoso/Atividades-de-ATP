/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 17/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace TesteVetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas;
            int i = 0;

            notas = new double[5];

            for (i = 0; i < 5; i++)
            {
                Console.Write("\nDigite a nota {0}: ", i);
                notas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nImpressão dos elementos do vetor (invertido)");

            // Impressão invertida
            for (i = 4; i >= 0; i--)
            {
                Console.WriteLine("\nNota {0} = {1} ", i, notas[i]);
            }

            Console.WriteLine("\t\tFim do programa ");
            Console.ReadKey();
        }
    }
}


