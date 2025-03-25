namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaração de variáveis
            int numero1 = 0;
            int numero2 = 0;

            // Solicitar números ao usuário
            Console.WriteLine("Digite um número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            numero2 = int.Parse(Console.ReadLine());

            // Processamento e comparação
            if (numero1 > numero2)
            {
                Console.WriteLine( numero1 );
            }
            else if (numero1 < numero2)
            {
                Console.WriteLine( numero2 );
            }
            else
            {
                Console.WriteLine("Os números são iguais");
            }
        }
    }
}
