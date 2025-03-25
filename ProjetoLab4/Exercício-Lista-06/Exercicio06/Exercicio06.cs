namespace Exercicio06 {
class Program
 {
    static void Main(string[] args)
    {
        //definir valor diaria
        Console.WriteLine("Digite o valor da diaria: ");
        Double diaria = Double.Parse(Console.ReadLine());

        //valor da diaria promocional
        Double diariapromocional= diaria * 0.75;

        //valor arrecadado com 80% de ocupação
        Double diariacomocupacao = (75 * 0.8) * diariapromocional;


        //valor arrecadado com 50% de ocupação
        Double diariasemocupacao = (75 *0.5) * diaria;

        //diferença das diarias ocupaçao e sem ocupaçao
        Double DiferencadeArrecadacao = diariacomocupacao - diariasemocupacao;

        //dando os resultados
        Console.WriteLine($"O valor da diária promocional é: R$ "+ diariapromocional);
        Console.WriteLine($"O valor total arrecadado com aumento da taxa de ocupação é: R$ "+ diariacomocupacao);
        Console.WriteLine($"O valor total arrecadado sem aumento na taxa de ocupação é: R$ "+ diariasemocupacao);
        Console.WriteLine($"Diferença entre os valores da ocupação é: R$ "+ DiferencadeArrecadacao);

    }
  } 
}
