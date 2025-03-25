namespace Exercicio07 {
class Program {
    static void Main(string[] args){


    // declarando variavel
    Double x= 0, y=0;

    //Pedindo o valor de X
    Console.WriteLine("Digite o valor de X: ");
    x = Double.Parse(Console.ReadLine());
    
    //condicoes
    if (x<=1) {
        y = 1;
}
    else if (x<=2 && x>1) {
        y = 2;
} 
    else if (x<=3 && x>2) {
        y= Math.Pow(x,2);
}    
    else 
{
        y= Math.Pow(x,3);
}


// valor de Y
Console.WriteLine($"O valor de Y é : {y}");

}
}
}