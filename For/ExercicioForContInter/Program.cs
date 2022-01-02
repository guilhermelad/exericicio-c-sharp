using System;

namespace ExercicioForContInter
{
    
    class Program
    {
       
        static void Main(String[] args)
        {

            Console.WriteLine("Digite quantos números você irá digitar");
            int x = int.Parse(Console.ReadLine());
            int cont_in = 0;
            int cont_out = 0;


            for (int i = 0; i != x; i++)
            {
                Console.WriteLine("Digite o valor: ");
                int valor = int.Parse(Console.ReadLine());

                if (valor >= 10 && valor <= 20)
                {
                    ++cont_in;

                }
                else
                {
                    ++cont_out;
                }


            }

            Console.WriteLine(cont_in +" in");
            Console.WriteLine(cont_out + " out");



        }




    }

   

}