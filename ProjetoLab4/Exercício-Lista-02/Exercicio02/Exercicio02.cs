namespace Exercicio02
{
    class Program   
    {
        static void Main(string[] args)    
        {

    //Declaração de variáveis
    int numero1= 0;
    int numero2= 0;
    int soma= 0;

    //Entrada de dados
    Console.WriteLine("Digite o primeiro número: ");
    numero1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    numero2 = int.Parse(Console.ReadLine());
    soma = numero1 + numero2;

    //Condições
        if (soma > 10)
        {
            soma = soma + 5;
            Console.WriteLine("O resultado da soma é: " + soma);

        }
            else if (soma < 10)
        {
            soma = soma + 7;
            Console.WriteLine("O resultado da soma é: " + soma);
        }
       
    }   
}
}
