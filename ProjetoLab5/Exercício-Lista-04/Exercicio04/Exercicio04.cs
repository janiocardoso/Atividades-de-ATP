/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 12/04/2025 (sábado)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um valor inteiro e positivo N: ");
            int N = int.Parse(Console.ReadLine());

            double E = 1.0;

            // Inicializa a variável do fatorial, começando com 1.
            double fatorial = 1;

            for (int i = 1; i <= N; i++)
            {

                // Calcula o fatorial de i 
                fatorial = fatorial * i;

                E += 1.0 / fatorial;
            }

            Console.WriteLine("O valor de E é: " + E);

        }
    }
}
