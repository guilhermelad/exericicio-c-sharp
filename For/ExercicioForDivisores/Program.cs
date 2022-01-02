using System;

namespace ExercicioForDivisores
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite o número: ");
            int n = int.Parse(Console.ReadLine());

            int mod;

            for (int i = 1; i <= n; i++)
            {
                mod = n % i;

                if (mod == 0)
                {
                    Console.WriteLine(i);
                }




            }


        }



    }


    


}