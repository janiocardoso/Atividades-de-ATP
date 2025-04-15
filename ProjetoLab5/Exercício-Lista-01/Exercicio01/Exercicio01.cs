/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 10/04/2025 (quinta-feira)
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
            //definindo as variaveis do programa
            int valor = 0;
            int contadorpositivo = 0;
            int contadorneutro = 0;
            int contadornegativo = 0;

            //encerrar programa
            Console.WriteLine("Digite 999 para encerrar o programa: ");

            //loop de repeticao com condicoes 
            do
            {
                Console.Write("Valor: ");
                valor = int.Parse(Console.ReadLine());

                if (valor == 999)
                {
                    break;
                }

                else if (valor > 0)
                {
                    contadorpositivo++;
                }
                else if (valor == 0)
                {
                    contadorneutro++;
                }
                else
                {
                    contadornegativo++;
                }

            } while (true);

            //Dando o resultado ao usuário
            Console.WriteLine($"O total de numeros positivos:{contadorpositivo}, neutros: {contadorneutro} e negativos: {contadornegativo}.");
        }
    }
}

