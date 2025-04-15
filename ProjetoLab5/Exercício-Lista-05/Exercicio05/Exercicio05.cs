/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 12/04/2025 (sábado)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/

using System; 

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalSalario = 0;
            int totalFilhos = 0;
            double maiorSalario = 0;
            double salariosAte100 = 0;
            int habitantes = 0;
            double salario;
            int filhos;

            // Início do loop que vai até o usuário informar um salário negativo
            do
            {
                Console.WriteLine("Digite o seu salário (negativo se quiser encerrar): ");
                salario = double.Parse(Console.ReadLine());

                // Condição de parada do programa
                if (salario < 0)
                    break;

                Console.WriteLine("Digite quantos filhos tem na sua residência: ");
                filhos = int.Parse(Console.ReadLine());

                // Atualiza os acumuladores com os dados lidos
                totalSalario += salario;
                totalFilhos += filhos;
                habitantes++; // Conta um novo habitante


                if (salario > maiorSalario)
                {
                    maiorSalario = salario; 
                }


                if (salario <= 100)
                {
                    salariosAte100++;
                }

            } while (salario >= 0);


            if (habitantes > 0)
            {
                // Cálculo das médias e percentual
                double mediaSalario = totalSalario / habitantes;
                double mediaFilhos = (double)totalFilhos / habitantes;
                double percentualSalariosAte100 = (salariosAte100 / habitantes) * 100;

                Console.WriteLine($"A média do salário da população é: R${mediaSalario:F2}");
                Console.WriteLine($"A média de filhos por habitante é: {mediaFilhos:F2}");
                Console.WriteLine($"O maior salário informado foi: R${maiorSalario:F2}");
                Console.WriteLine($"Percentual de pessoas com salário até R$100,00: {percentualSalariosAte100:F2}%");
            }
            else
            {
                Console.WriteLine("Nenhum dado foi inserido.");
            }
        }
    }
}
