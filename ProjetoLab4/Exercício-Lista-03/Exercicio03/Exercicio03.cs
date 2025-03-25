namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double a,b,x;
            Console.WriteLine("Digite o valor de A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            b = double.Parse(Console.ReadLine());

            if (a==0)
            {
                Console.WriteLine("A equação não é do primeiro grau.");
            }
            else
            {
                x = -b/a;
                Console.WriteLine("O valor de X é: " + x);
            }
        }
    }
}