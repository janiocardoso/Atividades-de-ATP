/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 15/04/2025 (terça-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite quantos elementos da série de Fibonacci deseja ver: ");
            int L = int.Parse(Console.ReadLine());
            int a = 0, b = 1;

            for (int i = 0; i < L; i++)
            {
                Console.Write(a + " "); // Imprime o valor atual
                int temp = a + b; // Soma os dois anteriores
                a = b; // Atualiza os valores para o próximo ciclo
                b = temp;
            }
        }
    }
}