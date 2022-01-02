using System;
using System.Globalization;




namespace ExercicioEstruturalMatematica
{

    class Program
    {

        static void Main(String[] args)
        {
            double area_trin, area_circu, area_trape, area_quadrado, area_retangulo;
            double a, b, c;
            

            Console.WriteLine("Digite o valor de A, B e C (na mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');


            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double ab = a + b;
            double c2 = Math.Pow(c, 2);
            double b2 = Math.Pow(b, 2);

            //Triangulo

            area_trin = (a * c) / 2;

            Console.WriteLine("Área do tringuangulo = " + area_trin.ToString("F3", CultureInfo.InvariantCulture));

            //Circulo
            area_circu = c2 * 3.14159f;
            Console.WriteLine("Área do Circulo = " + area_circu.ToString("F3", CultureInfo.InvariantCulture));

            //Trapezio 
            area_trape = (ab * c) / 2;
            Console.WriteLine("Área do Trapézio = " + area_trape.ToString("F3", CultureInfo.InvariantCulture));

            //Quadrado
            area_quadrado = b2;
            Console.WriteLine("Área do Quadrado = " + area_quadrado.ToString("F3", CultureInfo.InvariantCulture));

            //Retangulo
            area_retangulo = a * b;
            Console.WriteLine("Área do Retangulo = " + area_retangulo.ToString("F3", CultureInfo.InvariantCulture));



        }



    }



}