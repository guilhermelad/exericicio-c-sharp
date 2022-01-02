using System;
using System.Globalization;

namespace ExercicioClassesRetangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Retangulo r = new Retangulo();

            Console.WriteLine("Digita as informações do Retangulo:");
            Console.Write("Altura: ");
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Largura: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Área: " + r.AreaRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + r.PerimetroRetangulo().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + r.DiagonalRetangulo().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
