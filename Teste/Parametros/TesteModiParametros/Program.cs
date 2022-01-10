using System;

namespace TesteModiParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(1, 2);
            int s2 = Calculator.Sum(10, 10, 10, 10);


            Console.WriteLine(s1); 
            Console.WriteLine(s2);  
        }
    }
}
