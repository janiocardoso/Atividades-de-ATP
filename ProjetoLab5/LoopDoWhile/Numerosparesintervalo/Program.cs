using System;

namespace NumerosParesIntervalo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número inteiro positivo: ");
            int val1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número inteiro positivo: ");
            int val2 = int.Parse(Console.ReadLine());

            if (val1 >= val2)
            {
                Console.WriteLine("Erro: O primeiro número deve ser menor que o segundo.");
            }
            else
            {
                Console.WriteLine("Números ímpares no intervalo:");
                for (int i = val1; i < val2; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
