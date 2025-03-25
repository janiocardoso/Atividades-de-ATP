namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {
            

            // variaveis
            int velocidade= 0, velocidadepermitida= 50;

            // Perguntando a velocidade ao usuario
            Console.WriteLine("Em qual velocidade você estava dirigindo? ");
            velocidade =  int.Parse(Console.ReadLine());

            //condicoes
          
                if (velocidade > 50 && velocidade <= 60)
                {
                Console.WriteLine("Você deverá pagar uma multa de R$50 !!!");
                }
                 else if (velocidade > 60 && velocidade <= 80)
                {
                Console.WriteLine("Você deverá pagar uma multa de R$100 !!!");
                }
                else if (velocidade > 80 )
                {
                Console.WriteLine("Você deverá pagar uma multa de R$200 !!!");
                }
                else 
                {
                Console.WriteLine("O motorista respeitou a lei!");
                }

            
        }
    }
}