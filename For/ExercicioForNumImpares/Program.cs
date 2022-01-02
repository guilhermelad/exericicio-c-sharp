using System;


namespace ExercicioForNumImpares
{

    class Program
    {
        
        static void Main(String[] args)
        {

            Console.WriteLine("Digite um valor de 1 a 1000");
            int x = int.Parse(Console.ReadLine());


            for (int i = 1; i < x; i++)
            {
                if ( i % 2 != 0)
                {
                    Console.WriteLine(i);

                }


            }







        }



    }


}