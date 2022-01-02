 using System;
using System.Globalization;

namespace ExercicioClassesMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno p = new Aluno();


            Console.Write("Digite o nome do Aluno:");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            p.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (p.Aprovado())
            {
                Console.WriteLine("NOTA FINAL = " + p.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("NOTA FINAL = " + p.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + p.NotaRestante().ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
