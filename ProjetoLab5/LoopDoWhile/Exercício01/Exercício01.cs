/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 09/04/2025 (quarta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace LoopDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, contador = 0;
            string valorB = "";

            Console.WriteLine("Digite um numero inteiro positivo: ");
            valorB = Console.ReadLine();
            num = int.Parse(valorB);

            Console.WriteLine("Impressão de 0 até o número informado " + num);

            do
            {
                Console.WriteLine("\n\tContador = " + contador + " não chegou no número informado: " + num);
                Console.WriteLine("\tIncrementar contador");
                contador++;
            }
            while (contador < num);

            Console.WriteLine("\t\tFim do programa ");
            Console.ReadKey();
        }
    }
}
