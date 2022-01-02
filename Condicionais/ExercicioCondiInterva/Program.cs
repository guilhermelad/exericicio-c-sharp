using System;
using System.Globalization;


namespace ExercicioCondiInterva
{

    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Digite o valor de entrada:");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("intervalo [0,25]");

            } else if (valor > 25 && valor <= 50)
            {

                Console.WriteLine("intervalo [25,50]");

            } else if (valor > 50 && valor <= 75)
            {

                Console.WriteLine("intervalo [50, 75]");

            } else if (valor > 75 && valor <= 100) {

                Console.WriteLine("intervalo [75,100]");

            }
            else if (valor < 0 || valor > 100)
            {

                Console.WriteLine("Fora do Intervalo");
            }






        }


    }


}