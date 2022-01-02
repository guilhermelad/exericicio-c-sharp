using System;
using System.Globalization;


namespace ExercicioEstruturalSalDollar
{

    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Digite o código do funcionário, horas trabalhadas e valor que receber por hora: ");
            string[] vet = Console.ReadLine().Split(' ');


            int codigo = int.Parse(vet[0]);
            int horas = int.Parse(vet[1]); 
            double valor_hora = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double salario = horas * valor_hora;


            Console.WriteLine("Código do funcionário é: " + codigo);
            Console.WriteLine("Pelas " + horas + " hora trabalhadas o mesmo irá ganhar U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            




        }


    }



}