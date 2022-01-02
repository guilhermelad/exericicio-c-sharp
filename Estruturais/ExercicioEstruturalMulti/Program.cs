using System;
using System.Globalization;


namespace ExercicioEstruturalMulti 
{ 

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite o valor do raio:");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = 3.14159 * (Math.Pow(raio, 2.0));

            Console.WriteLine("O resultado do área é: " + resultado.ToString("F4", CultureInfo.InvariantCulture));

            
           



        }


    }


}