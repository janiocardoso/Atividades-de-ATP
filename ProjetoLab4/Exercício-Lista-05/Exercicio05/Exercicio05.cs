namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
             // declaração de variáveis
            int nota = 0;
            Console.WriteLine("Digite a nota do aluno: ");
            nota = int.Parse(Console.ReadLine());

            // condição 
            if (nota >=8 && nota <=10)
            Console.WriteLine("Ótimo");

            else if (nota >=7 && nota <8)
            Console.WriteLine("Bom");

            else if (nota >=5 && nota <7)
            Console.WriteLine("Regular");

            else if (nota <=4)
            Console.WriteLine("Insuficiente");
            
        }
    }
}