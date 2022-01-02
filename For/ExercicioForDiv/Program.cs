using System;
using System.Globalization;


namespace ExercicioForDiv
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite a quantidade de vezes que será digitado os números:");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite os dois números na mesma linha");
                string[] vet = Console.ReadLine().Split(' ');

                int a = int.Parse(vet[0], CultureInfo.InvariantCulture);
                int b = int.Parse(vet[1], CultureInfo.InvariantCulture);

               

                

                if (b != 0)
                {
                    double resultado = (double)a / b;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));


                }
                else
                {
                    Console.WriteLine("divisão impossível");
                }
                


            }
            





        }



    }
}