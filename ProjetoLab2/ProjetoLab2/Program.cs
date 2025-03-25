namespace ProjetoLab2

 { 
     internal class Program
      {
        static void Main(string[] args)
        {
            int idade = 18;
            double altura = 1.80;
            string nome = "Jânio Cardoso";
            //
            string produto = "Maça";
            int quantidade = 5;
            double precoUnitario = 2.5;
            //
            double preco = 2.5;
            //
            int numero = 42;
            double valor = 1234.56789;
            //01,02-
            Console.WriteLine("Hello World!");
            //03-
            Console.WriteLine(" ");
            Console.WriteLine("Olá, aluno!");
            Console.WriteLine("Seja bem vindo a Puc Minas");
            Console.WriteLine("Exemplos do Console.WriteLine em C#.");
            //04-
            Console.WriteLine(" ");
            Console.WriteLine("Idade " + idade);
            Console.WriteLine("Altura " + altura);
            Console.WriteLine("Nome " + nome);
            //05-
            Console.WriteLine(" ");
            Console.WriteLine("{0} unidades de {1} custam {2:C}.", quantidade, produto, quantidade * precoUnitario);
            //06-
            Console.WriteLine(" ");
            Console.WriteLine($"Idade {idade}, Altura:{altura}, Nome: {nome}");
            //07-
            Console.WriteLine(" ");
            Console.WriteLine("Número formatado: {0:D5}", numero);
            Console.WriteLine("Valor formatado: {0:F2}", valor);
            Console.WriteLine("Valor formatado: {0:C}", valor);
            //08-
            Console.WriteLine(" ");
            Console.WriteLine("Produto: {0,-10} | Preço: {1,8}", produto, preco);
            //09-
            Console.WriteLine(" ");
            Console.WriteLine("Quebra de linha: \nTabulação: \tAspas duplas: \"");
            //10-
            Console.WriteLine(" ");
            Console.Write("Olá, ");
            Console.Write("mundo!");
            Console.WriteLine(" ");
            Console.ReadKey();
            //saída : "Olá, mundo!"



            int anoAtual= 0, anoNascimento= 0, Idade= 0;
            string texto = null;
            Console.WriteLine("Digite o ano atual:");
            texto = Console.ReadLine();
            anoAtual = int.Parse(texto);
            Console.Write("Digite seu ano de nascimento:");
            anoNascimento = int.Parse(Console.ReadLine());
            Idade = anoAtual - anoNascimento; 
            Console.WriteLine("Idade= {0}", Idade );
            Console.ReadLine();
            
 }
     }
        } 

 

