using System;
using System.Globalization;



namespace baskara{

    class Program{
        static void Main(String[] args){

            //Calcular Baskara
            Console.WriteLine("Digite os valores de A, B e C ( na mesma linha) ");
            string[] vet = Console.ReadLine().Split(' ');

            double a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double b = double.Parse(vet[1], CultureInfo.InvariantCulture);    
            double c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            if (a == 0.0 || delta < 0.0){

                Console.WriteLine("IMPOSSIVEL CALCULAR");

            }   
            else{

                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                    Console.WriteLine("Delta = " + delta.ToString("F2", CultureInfo.InvariantCulture));
                    Console.WriteLine("Valor de x1 = {0}", x1);
                    Console.WriteLine("Valor de x2 = {0}", x2);

             }
        }
    }
}