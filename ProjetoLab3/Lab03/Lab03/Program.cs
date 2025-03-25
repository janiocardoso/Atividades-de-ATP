using System;
using System.ComponentModel.Design;
class Program
{
    public static void Main(string[] args)
    {
        //declaracao de variaveis
        Console.Write("Digite o valor de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o valor de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        //calculo delta
        double delta = Math.Pow(b, 2) - 4 * a * c;

        if (delta < 0)
        {
            Console.Write("Não existem raizes reais");

        }
        else if (delta > 0); 
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);     
               
            Console.Write($"As raizes sao:{x1} e {x2}");
        }     
    }
}