/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 15/04/2025 (terça-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            int candidato1 = 0;
            int candidato2 = 0;
            int candidato3 = 0;
            int candidato4 = 0;
            int nulos = 0;
            int brancos = 0;

            int voto;

            Console.WriteLine("Digite os votos (1 a 6). Digite 0 para encerrar.");

            while (true)
            {
                Console.Write("Código do voto: ");
                voto = int.Parse(Console.ReadLine());

                if (voto == 0)
                    break; // Se o voto for 0, encerra o programa

                // Verifica o código do voto e atualiza o contador correspondente
                switch (voto)
                {
                    case 1:
                        candidato1++;
                        break;
                    case 2:
                        candidato2++;
                        break;
                    case 3:
                        candidato3++;
                        break;
                    case 4:
                        candidato4++;
                        break;
                    case 5:
                        nulos++;
                        break;
                    case 6:
                        brancos++;
                        break;
                    default:
                        // Caso o usuário digite um número inválido (diferente de 0 a 6)
                        Console.WriteLine("Código inválido! Digite um número entre 1 e 6 ou 0 para encerrar.");
                        break;
                }
            }

            Console.WriteLine($"Candidato 1: {candidato1} voto(s)");
            Console.WriteLine($"Candidato 2: {candidato2} voto(s)");
            Console.WriteLine($"Candidato 3: {candidato3} voto(s)");
            Console.WriteLine($"Candidato 4: {candidato4} voto(s)");
            Console.WriteLine($"Votos nulos: {nulos}");
            Console.WriteLine($"Votos em branco: {brancos}");
        }
    }
}