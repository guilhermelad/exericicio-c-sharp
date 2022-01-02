using System;
using System.Globalization;

namespace ExercicioClassesFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionarios  p1 , p2;

            p1 = new Funcionarios();
            p2 = new Funcionarios();
            double media;

            Console.WriteLine("Digite o nome e o salario do primeiro funcionário:");
            p1.nome = Console.ReadLine();
            p1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome e o salario do segundo funcionário: ");
            p2.nome = Console.ReadLine();
            p2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.WriteLine("Nome: " + p1.nome);
            Console.WriteLine("Salário: R$" + p1.salario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Dados do segundo funcionário: ");
            Console.WriteLine("Nome: " + p2.nome);
            Console.WriteLine("Salário: R$" + p2.salario.ToString("F2", CultureInfo.InvariantCulture));


            media = (p1.salario + p2.salario) / 2;
            Console.WriteLine("Media salarial: R$" + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
