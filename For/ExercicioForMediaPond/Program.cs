using System;
using System.Globalization;


namespace ExercicoForMediaPond
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o número de entradas.");
            int x = int .Parse(Console.ReadLine()); 

            for ( int i = 0; i < x; i++)
            {
                Console.WriteLine("Digite as notas todas na mesma linha: ");
                string[] vet = Console.ReadLine().Split(' ');

                double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

                double resultado = (a * 2.0 + b * 3.0 + c * 5.0) / (2 + 3 + 5);

                Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));



            }






        }



    }




}