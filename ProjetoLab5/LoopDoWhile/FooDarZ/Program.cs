using System;

class FooBarBaz
{
     static void PrintFooBarBaz(int i)
    {
        Console.Write(i);

        if (i % 3 == 0) Console.Write(" foo");
        if (i % 5 == 0) Console.Write(" bar");
        if (i % 7 == 0) Console.Write(" baz");

        Console.WriteLine();
    }
    static void Main()
    {
        Console.WriteLine("Usando FOR:");
        for (int i = 1; i <= 50; i++)
        {
            PrintFooBarBaz(i);
        }

        Console.WriteLine("\nUsando WHILE:");
        int j = 1;
        while (j <= 50)
        {
            PrintFooBarBaz(j);
            j++;
        }

        Console.WriteLine("\nUsando DO WHILE:");
        int k = 1;
        do
        {
            PrintFooBarBaz(k);
            k++;
        } while (k <= 50);
    }

}
