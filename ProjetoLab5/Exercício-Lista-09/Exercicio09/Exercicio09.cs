/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 15/04/2025 (terça-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {

            // Contadores para cada faixa de lucro
            int lucroMenor10 = 0, lucroEntre10e20 = 0, lucroMaior20 = 0;
            // Acumuladores de valores
            double totalCompra = 0, totalVenda = 0;

            while (true)
            {
                Console.Write("Preço de compra (0 para encerrar): ");
                double compra = double.Parse(Console.ReadLine());

                if (compra == 0) break; 

                Console.Write("Preço de venda: ");
                double venda = double.Parse(Console.ReadLine());

                // Cálculo do lucro percentual
                double lucroPercentual = ((venda - compra) / compra) * 100;

                // Classificação da faixa de lucro
                if (lucroPercentual < 10)
                    lucroMenor10++;
                else if (lucroPercentual <= 20)
                    lucroEntre10e20++;
                else
                    lucroMaior20++;

                // Soma dos totais
                totalCompra += compra;
                totalVenda += venda;
            }

            // Exibição dos resultados
            Console.WriteLine($"Lucro < 10%: {lucroMenor10}");
            Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
            Console.WriteLine($"Lucro > 20%: {lucroMaior20}");
            Console.WriteLine($"Total de compra: R$ {totalCompra:F2}");
            Console.WriteLine($"Total de venda: R$ {totalVenda:F2}");
            Console.WriteLine($"Lucro total: R$ {totalVenda - totalCompra:F2}");
        }
    }
}
