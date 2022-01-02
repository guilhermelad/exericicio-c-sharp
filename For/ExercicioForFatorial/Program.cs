using System;


namespace ExericioForFatorial
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite um valor para calcular o fatorial");
            int n = int.Parse(Console.ReadLine());
            int fat = 1;
    


            for (int i = 1; i <= n ; i++)
            {
                fat = fat * i;
                
                
            }

            Console.WriteLine(fat);

           




        }



    }


}