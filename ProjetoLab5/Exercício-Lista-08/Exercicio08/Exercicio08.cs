/**
* PUC Minas, Campus Contagem.
* ATP Aula Prática
* Data: 15/04/2025 (terça-feira)
* @author Jânio Júnio de Freitas Cardoso
* Objetivo: praticar a criação de variáveis e tipos no C#.
* Data e descrição da última manutenção: dd/MM/yyy - texto da alteração.
*/
namespace Exercicio08
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Digite o valor limite da série de Fibonacci: ");
      int L = int.Parse(Console.ReadLine()); // Valor máximo
      int a = 0, b = 1; 

      while (a < L)
      {
        Console.Write(a + " "); // Imprime o termo atual
        int temp = a + b; // Calcula próximo termo
        a = b; // Avança na sequência
        b = temp;
      }
    }
  }
}