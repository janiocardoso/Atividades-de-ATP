using System;

namespace MediaNumerica
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, soma = 0, contador = 0;

            do
            {
                Console.Write("Digite um número inteiro positivo (-1 para sair): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != -1)
                {
                    soma += numero;
                    contador++;
                }

            } while (numero != -1);

            if (contador > 0)
            {
                double media = (double)soma / contador;
                Console.WriteLine("A média dos números digitados é: " + media);
            }
            else
            {
                Console.WriteLine("Nenhum número foi digitado.");
            }

            Console.ReadKey();
        }
    }
}
