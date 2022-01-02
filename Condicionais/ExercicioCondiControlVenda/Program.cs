using System;
using System.Globalization;

namespace ExercicioCondiControlVenda
{

    class Program
    {

        static void Main(String[] args)
        {

            Console.WriteLine("Digite o código do produto e a quantidade:");
            string[] vet = Console.ReadLine().Split(' ');

            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);
            double valor;

            if (codigo == 1)
            {

                valor = quantidade * 4.00;
                Console.WriteLine("O valor de " + quantidade + " Cachorro Quente é de R$ " + valor.ToString("F2"));


            }
            else if (codigo == 2)
            {

                valor = quantidade * 4.50;
                Console.WriteLine("O valor de " + quantidade + " X-Salada é de R$ " + valor.ToString("F2"));

            }
            else if (codigo == 3)
            {

                valor = quantidade * 5.00;
                Console.WriteLine("O valor de " + quantidade + " X-Bacon é de R$ " + valor.ToString("F2"));


            }
            else if (codigo == 4)
            {

                valor = quantidade * 2.00;
                Console.WriteLine("O valor de " + quantidade + " Torrada Simples é de R$ " + valor.ToString("F2"));

            }
            else if (codigo == 5)
            {

                valor = quantidade * 1.50;
                Console.WriteLine("O valor de " + quantidade + " Refrigerante é de R$ " + valor.ToString("F2"));

            }
            else
            {
                Console.WriteLine("Produto não cadastrado");
            }


        }
    }


}