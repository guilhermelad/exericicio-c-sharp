using System;
using System.Globalization;

namespace ExericicoClasseEstaticaDolar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar? ");
            double cot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos dólares você vai comprar? ");
            double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = Conversor.RealDolar(cot, val);
            Console.WriteLine("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
