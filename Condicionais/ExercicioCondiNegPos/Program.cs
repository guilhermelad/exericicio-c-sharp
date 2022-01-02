using System;
using System.Globalization;


namespace ExercicioCondiNegPos
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite o número: ");
            int a = int.Parse(Console.ReadLine());


            if (a > 0)
            {

                Console.WriteLine("O número {0} é POSITIVO", a);

            }
            else
            {
                Console.WriteLine("O número {0} é NEGATIVO", a);
            }


        }


    }

}
