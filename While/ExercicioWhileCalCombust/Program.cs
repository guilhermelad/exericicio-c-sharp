using System;

namespace ExercicioWhileCalCombust
{

    class Program
    {

        static void Main(String[] args)
        {
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("Digite 1 - para Álcool, 2 - Gasolina, 3 - Diesel e 4 para finalizar.");
            int codigo = int.Parse(Console.ReadLine());
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            while (codigo != 4)
            {

                if (codigo == 1)
                {
                    alcool = ++alcool;

                } else if (codigo == 2)
                {
                    gasolina = ++gasolina;

                } else if (codigo == 3)
                {
                    diesel = ++diesel;
                } else if (codigo > 4 || codigo < 0)
                {

                    Console.WriteLine("----------------------------------------------------------------------");
                    Console.WriteLine("Digite o valor corretamente");


                }

                Console.WriteLine("Digite 1 - para Álcool, 2 - Gasolina, 3 - Diesel e 4 para finalizar.");
                Console.WriteLine("----------------------------------------------------------------------");
                codigo = int.Parse(Console.ReadLine());


            }

           
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }

            


}






