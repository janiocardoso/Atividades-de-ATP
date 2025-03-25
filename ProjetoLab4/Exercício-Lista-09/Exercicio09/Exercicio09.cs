namespace Exercicio08 {
    class Program {
        static void Main(string[] args) {

    // pedindo o simbolo para o usuario
    Console.WriteLine("Digite um símbolo: ");
    char simbolo= char.Parse(Console.ReadLine());

    //Condicoes
    switch (simbolo){
    case'<':
    Console.Write("Sinal de Menor");
    break;
    case'>':
    Console.Write("Sinal de Maior");
    break;
    case'=':
    Console.Write("Sinal de Igual");
    break;
    default:
    Console.WriteLine("Símbolo Qualquer");
    break;

   }
  }
 }
}