namespace Exercicio08 {
class Program {
    static void Main(string[] args) {
    // variaveis
    double salario = 0; double resultado = 0;
    char opcao;

    //pedindo salario
    Console.WriteLine("Digite o Salário: ");
    salario = double.Parse(Console.ReadLine());

    //pedindo taxa
    Console.WriteLine("Digite a opção (A, B ou C): ");
    opcao = char.Parse(Console.ReadLine());  
    
    //todas as condicoes
    switch (opcao){

    case 'A':
    resultado= salario + 0.08 * salario;
    break;

    case 'B':
    resultado= salario + salario * 0.11;
    break;

    case 'C':
    if (salario <=1000) 
    {
    resultado= salario + 350;
    }
    else if (salario > 1000)
    {
    resultado= salario + 200;
    }      
    break;

    default: 
    Console.WriteLine("Opção Inválida!");
    return;

    }

    // retorna o resultado
    Console.WriteLine($"O valor do Salário é: " + resultado);

   
  }
 }
}