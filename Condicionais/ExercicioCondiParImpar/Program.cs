using System;
using System.Globalization;

namespace ExercicioCondiParImpar
{

    class Program
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Digite o valor: ");
            int a = int.Parse(Console.ReadLine());

            int mod = a % 2;
            
            if (mod == 0)
            {

                Console.WriteLine("O número {0} é PAR", a);

            }
            else
            {
                Console.WriteLine("O número {0} é IMPAR", a);
            }



        }


    }

}