/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 10/04/2025 (quinta-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
using System;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis

            int divisivel3e9 = 0;
            int divisivel2 = 0;
            int divisivel5 = 0;

            //usando o for para um loop limitado a 10 valores.
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Digite o {i}º número: ");
                int numero = int.Parse(Console.ReadLine());
                bool divisivel = false;

                //valor divisivel por 9 e 3
                if (numero % 3 == 0 && numero % 9 == 0)
                {
                    Console.WriteLine("Divisivel por 3 e 9");
                    divisivel3e9++;
                    divisivel = true;
                }

                //valor divisivel por 2
                if (numero % 2 == 0)
                {
                    Console.WriteLine("Divisivel por 2");
                    divisivel2++;
                    divisivel = true;
                }

                //valor divisivel por 5
                if (numero % 5 == 0)
                {
                    Console.WriteLine("Divisivel por 5");
                    divisivel5++;
                    divisivel = true;
                }

                if (!divisivel)
                {
                    Console.WriteLine(" Número não é divisível pelos valores");
                }
                // Para sair do loop
                if (numero == 999)
                {
                    Console.WriteLine("Encerrando o programa.");
                    break;
                }

                Console.WriteLine($"Quantidade de números divisíveis por 3 e 9: {divisivel3e9}");
                Console.WriteLine($"Quantidade de números divisíveis por 2: {divisivel2}");
                Console.WriteLine($"Quantidade de números divisíveis por 5: {divisivel5}");

            }
        }
    }
}