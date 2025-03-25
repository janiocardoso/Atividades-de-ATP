namespace Exercicio10 {
    class Program {
        static void Main(string[] args) {
            //variaveis
            double prova1A=0;
            double prova1B=0;
            double prova2A=0;
            double prova2B=0;
            double atividades=0;
            double frequencia=0;
            double reavaliaçao=0;

            //pedindo as notas do usuario
            Console.WriteLine("Digite a sua nota da prova 1A: ");
            prova1A= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota da prova 1B: ");
            prova1B= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota da prova 2A: ");
            prova2A= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota da prova 2B: ");
            prova2B= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua nota das atividades: ");
            atividades= double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua frequencia nas aulas: ");
            frequencia= double.Parse(Console.ReadLine());

            

            //calculando as notas
            double notas= prova1A + prova1B + prova2A + prova2B + atividades;

            //condicoes
            if (notas>=60 && frequencia>=75) 
            {
                //mostra as notas ao usuario
                Console.WriteLine("Nota da prova 1A: " + prova1A);
                Console.WriteLine("Nota da prova 1B: " + prova1B);
                Console.WriteLine("Nota da prova 2A: " + prova2A);
                Console.WriteLine("Nota da prova 2B: " + prova2B);
                Console.WriteLine("Nota das atividades: " + atividades);
                Console.WriteLine("Frequência: " + frequencia +"%");
                Console.WriteLine("Nota total: " + notas);

                Console.WriteLine("Você está Aprovado!!!");

            }
            else if (notas<60 && frequencia >=75)
                {  
                //mostra as notas ao usuario
                Console.WriteLine("Nota da prova 1A: " + prova1A);
                Console.WriteLine("Nota da prova 1B: " + prova1B);
                Console.WriteLine("Nota da prova 2A: " + prova2A);
                Console.WriteLine("Nota da prova 2B: " + prova2B);
                Console.WriteLine("Nota das atividades: " + atividades);
                Console.WriteLine("Frequência: " + frequencia +"%");
                Console.WriteLine("Nota total: " + notas);

                Console.WriteLine("O aluno deverá realizar uma reavaliação de valor 40 pontos!");
            }

            else {

                Console.WriteLine("Você está Reprovado");
                
                //mostra as notas ao usuario  
                Console.WriteLine("Frequência: " + frequencia +"%");
                Console.WriteLine("Nota da prova 1A: " + prova1A);
                Console.WriteLine("Nota da prova 1B: " + prova1B);
                Console.WriteLine("Nota da prova 2A: " + prova2A);
                Console.WriteLine("Nota da prova 2B: " + prova2B);
                Console.WriteLine("Nota das atividades: " + atividades);
                Console.WriteLine("Nota total: " + notas);
     
            }
     
        }
    }
}