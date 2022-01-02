using System;
using System.Globalization;



namespace ExercicioCondiPlanoCarte
{

    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Digite os dois valores na mesma linha");
            string[] vet = Console.ReadLine().Split(' ');

            double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet[1], CultureInfo.InvariantCulture);



            if (x > 0 && y > 0)
            {

                Console.WriteLine("Quadrante 1");

            }else if (x < 0 && y > 0)
            {

                Console.WriteLine("Quadrante 2");

            }else if (x < 0 && y < 0)
            {

                Console.WriteLine("Quadrante 3");

            }else if (x > 0 && y < 0)
            {

                Console.WriteLine("Quadrante 4");

            }else if (x == 0 && y == 0) 
            {

                Console.WriteLine("Origem");

            }
        }

    }


}