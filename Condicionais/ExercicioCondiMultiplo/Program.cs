using System;
using System.Globalization;

namespace ExercicioCondiMultiplo
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite o primeiro valor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int b = int.Parse(Console.ReadLine());


            if ( a % b == 0 || b % a == 0)
            {
                Console.WriteLine("Os números {0} e {1} são múltiplos.", a, b);
            }
            else
            {
                Console.WriteLine("Os números {0} e {1} não são múltiplos.", a, b);
            }

        }

    }


}