namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
           int anoNascimento = 0;
           int anoAtual = 0;
           int idade = 0;
           string resposta = "";

           //Entrada de dados
           Console.WriteLine("Informe o ano de nascimento: ");
           anoNascimento= int.Parse(Console.ReadLine());

           Console.WriteLine("Informe o ano atual: ");
           anoAtual= int.Parse(Console.ReadLine());

           Console.WriteLine("Você já fez aniversário este ano? (S/N)");
           resposta= Console.ReadLine();

           //cauculo da idade
           idade = anoAtual - anoNascimento;

           //Condição para verificar se a pessoa já fez aniversário
           if (resposta == "N")
           {
               idade = idade - 1;
               Console.WriteLine("Sua idade é: " + idade);
           }
           else
           {
               Console.WriteLine("Sua idade é: " + idade);
           }
           
           //Condição para verificar se a pessoa é maior de idade
           if (idade>=18)
           {
               Console.WriteLine("Você pode adquirir Carteira de Habilitação.");
           }
           else if (idade<18)
           {
               Console.WriteLine("Você ainda é menor de idade.");
           }

        }
    }
}
