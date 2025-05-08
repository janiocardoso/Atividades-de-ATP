using System;
public class Program {
    public static void Main() {
        int [,] matrizA = new int[3,2];
        int [,] matrizB = new int[3,2];
        int [,] matrizResultante = new int[3,2];


        
        for (int i = 0; i < 3; i++) {

            for (int j = 0; j < 2; j++) {
                matrizA[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++) {

            for (int j = 0; j < 2; j++) {
                matrizB[i, j] = int.Parse(Console.ReadLine());
            }
        }
        for (int i = 0; i < 3; i++) {

            for (int j = 0; j < 2; j++) {
                matrizResultante[i, j] = matrizA[i, j] * matrizB[i, j];
            }
        }
        for (int i = 0; i < 3; i++) {
            
            for (int j = 0; j < 2; j++) {
            Console.WriteLine($"{matrizResultante[i, j]}");
            }
        }
    }
}