using System;


namespace ExercicioForQuadraCubo
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite o número: ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                double n2;
                double n3;


                
                n2 = Math.Pow(i, 2);
                n3 = Math.Pow(i, 3);
                Console.WriteLine(i + " " + n2 + " " + n3);





            }





        }


    }



}