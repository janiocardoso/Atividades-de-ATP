using System;
public class Program {
    public static void Main() {
        int [,] matriz = new int[2,2];
        
        for (int i = 0; i < 2; i++) {

            for (int j = 0; j < 2; j++) {
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }
            int maior = matriz[0,0];
            int menor = matriz[0,0];

            foreach (int elemento in matriz) {
                
                if (elemento > maior  ) {
                    maior = elemento;
                }
                if (elemento < menor ) {
                    menor = elemento;
                }
            }
            int soma = maior + menor;
            Console.WriteLine($"SOMA = {maior + menor}");
    }
}