using System;


namespace ExecicioEstruturalSoma {

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite o primeiro valor que deseja somar:"); 
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor que deseja somar:");
            int b = int.Parse(Console.ReadLine());



            int c = a + b;

            Console.WriteLine("O valor da soma dos números {0} e {1} é igual á {2}", a, b, c);



        }
    }

}
