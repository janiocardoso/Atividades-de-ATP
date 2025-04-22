/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 17/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas;
            int i = 0;

            notas = new double[5];

            notas[0] = 10;
            notas[1] = 5;
            notas[2] = 8;
            notas[3] = 2;
            notas[4] = 8;

            Console.WriteLine("\nImpressão dos elementos do vetor");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("\nNota {0} = {1} ", i, notas[i]);
            }

            Console.WriteLine("\n\t\tFim do programa ");
            Console.ReadKey();
        }
    }
}
