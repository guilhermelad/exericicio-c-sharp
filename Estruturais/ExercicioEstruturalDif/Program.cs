using System;


namespace ExercicioEstruturalDif
{

    class Program
    {

        static void Main(String[] args)
        {
            int A, B, C, D, dif;


            Console.WriteLine("Digite a seguir os valores de A, B, C e D:");
            Console.WriteLine("A: ");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("C: ");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("B: ");
            D = int.Parse(Console.ReadLine());

            dif = A * B - C * D;


            Console.WriteLine("O resultado da expressão (A * B - C * D) é igual á: {0}", dif);


        }


    }

}