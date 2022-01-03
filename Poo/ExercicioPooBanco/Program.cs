using System;
using System.Globalization;

namespace ExercicioPooBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valordeposito, valorsaque;
            

            Console.Write("Entre com o número da conta: ");
            int numeroconta = int.Parse(Console.ReadLine());
            Console.Write("Entre o Titular da conta: ");
            string nometitular = Console.ReadLine();
            Console.Write("Haver deposito inicial? (s/n)");
            char validar = char.Parse(Console.ReadLine());
            ContaBancaria conta = new ContaBancaria(nometitular, numeroconta);
            if (validar == 's')
            {
                Console.Write("Entre com o valor de depósito incial: ");
                valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valordeposito);
                
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor de depósito: ");
            valordeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(valordeposito);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor de saque: ");
            valorsaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(valorsaque);
            Console.WriteLine("Dados da conta atualizado: ");
            Console.WriteLine(conta);



        }
    }
}
