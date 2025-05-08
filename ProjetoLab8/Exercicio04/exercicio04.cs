using System;
public class Program {
    public static void Main() {
        int alunos = int.Parse(Console.ReadLine());
        int atividades = int.Parse(Console.ReadLine());

        double[,] notas = new double[alunos, atividades];
        double[] total = new double[alunos];

        for (int i = 0; i < alunos; i++)
        {
            for (int j = 0; j < atividades; j++)
            {
                notas[i, j] = double.Parse(Console.ReadLine());
                total[i] += notas[i, j]; 
            }
        }

        double maiorNota = total[0], menorNota = total[0];

        int[] alunosMaior = new int[alunos];
        int[] alunosMenor = new int[alunos];
        int countMaior = 0, countMenor = 0;

        for (int i = 0; i < alunos; i++)
        {
            if (total[i] > maiorNota)
            {
                maiorNota = total[i];
                countMaior = 0;
                alunosMaior[countMaior] = i + 1;
                countMaior++;
            }
            else if (total[i] == maiorNota)
            {
                alunosMaior[countMaior] = i + 1;
                countMaior++;
            }

            if (total[i] < menorNota)
            {
                menorNota = total[i];
                countMenor = 0;
                alunosMenor[countMenor] = i + 1;
                countMenor++;
            }
            else if (total[i] == menorNota)
            {
                alunosMenor[countMenor] = i + 1;
                countMenor++;
            }
        }

        Console.WriteLine("Total de notas de Cada Aluno:");
        for (int i = 0; i < alunos; i++)
        {
            Console.WriteLine($"Aluno {i + 1}: {total[i]}");
        }

        Console.WriteLine("\nAluno com Maior Total de notas:");
        for (int i = 0; i < countMaior; i++)
        {
            Console.WriteLine($"Aluno {alunosMaior[i]} ({maiorNota})");
        }

        Console.WriteLine("\nAluno com Menor Total de notas:");
        for (int i = 0; i < countMenor; i++)
        {
            Console.WriteLine($"Aluno {alunosMenor[i]} ({menorNota})");
        }
    }
}
