using System;
public class Program {
    public static void Main() {
        int [,] matriz = new int[3,2];
        int [,] matrizModificada = new int[3,2];

        for (int i = 0; i < 3; i++) {

            for (int j = 0; j < 2; j++) {
                matriz[i, j] = int.Parse(Console.ReadLine()); 
                if ( matriz[i, j] < 0){
                    matrizModificada[i, j] = 0;
                }
                else{
                    matrizModificada[i, j] = matriz[i, j];
                }
            }
        }
        for (int i = 0; i < 3; i++) {
            
            for (int j = 0; j < 2; j++) {
                Console.WriteLine($"{matrizModificada[i, j]}");
            }
        }
    }
}