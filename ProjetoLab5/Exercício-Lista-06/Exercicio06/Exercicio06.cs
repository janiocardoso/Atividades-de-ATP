/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 15/04/2025 (terça-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número inteiro positivo: ");
            int n = int.Parse(Console.ReadLine()); 
            double soma = 0; // Acumulador da soma

            for (int i = 1; i <= n; i++)
            {
                double termo = 1.0 / i; // Calcula o termo atual da série
                Console.WriteLine($"1/{i} = {termo:F4}"); // Mostra o termo formatado
                soma += termo; // Soma ao total
            }

            Console.WriteLine($"Soma total: {soma:F4}"); 
        }
    }
}
