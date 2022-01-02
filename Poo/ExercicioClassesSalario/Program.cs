using System;
using System.Globalization;

namespace ExercicioClassesSalario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario p = new Funcionario();

            Console.WriteLine("Digite as informações solicitadas");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            p.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture) ;


            Console.WriteLine();
            Console.WriteLine("Funcionário: " + p.SalarioLuquido().ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.AumentarSalario(porcent);

            Console.WriteLine( );
            Console.WriteLine("Dados Atualizados: " + p);
            

        }
    }
}
