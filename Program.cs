using System;
using System.Globalization;

namespace AprovadoOuReprovado
{
    class Program
    {
        /*Recebe notas do aluno, calcula a média e mostra se aluno foi aprovado ou reprovado. No último caso, retorna quantos pontos faltam para ser aprovado.*/

        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.WriteLine("Nome do aluno: ");
            aluno.Nome = Console.ReadLine()!;
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.Nota1 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + aluno.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));

            if (aluno.Aprovado())
                Console.WriteLine("Aprovado!");

            else
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram " + aluno.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos.");
                

        }
    }
}
