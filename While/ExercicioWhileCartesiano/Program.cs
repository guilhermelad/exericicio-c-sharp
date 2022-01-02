using System;

namespace ExercicioWhileCartesiano
{

    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Digite o valor de X e Y (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');

            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0)
            {

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");

                }else if (x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");

                }else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");

                }else if (x > 0 && y < 0){
                    Console.WriteLine("Quarto");
                };


                vet = Console.ReadLine().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);




            }






        }



    }



}