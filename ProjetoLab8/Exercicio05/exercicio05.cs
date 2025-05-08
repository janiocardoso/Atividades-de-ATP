using System;
public class Program {
    public static void Main() {
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());

        double[,] matriz = new double[N, M];

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double busca = double.Parse(Console.ReadLine());
        int encontrado = 0;

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                if (matriz[i, j] == busca)
                {
                    Console.WriteLine($"({i},{j})");
                    encontrado++;
                }
            }
        }

        if (encontrado == 0)
        {
            Console.WriteLine("NUMERO NAO ENCONTRADO");
        }
    }
}
