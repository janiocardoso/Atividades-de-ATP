
using System;

class MaiorMenor
{
    static void Main()
    {
        int numero;
        int maior = -1;
        int menor = int.MaxValue;

        while (true)
        {
            Console.Write("Digite um número inteiro positivo (-1 para sair): ");
            numero = int.Parse(Console.ReadLine());

            if (numero == -1)
                break;

            if (numero > maior)
                maior = numero;

            if (numero < menor)
                menor = numero;
        }

        Console.WriteLine("Maior número digitado: " + maior);
        Console.WriteLine("Menor número digitado: " + menor);
    }
}
