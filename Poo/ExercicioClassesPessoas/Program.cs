using System;

namespace ExercicioClassesPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados pessoa1, pessoa2;


            pessoa1 = new Dados();
            pessoa2 = new Dados();


            Console.WriteLine("Digite o nome e depois a idade para cadastro: ");
            pessoa1.Nome = Console.ReadLine();
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa e depois a idade para cadastro: ");
            pessoa2.Nome = Console.ReadLine();
            pessoa2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da primeira pessoa:");
            Console.WriteLine("Nome: " + pessoa1.Nome);
            Console.WriteLine("Idade: " + pessoa1.Idade);
            Console.WriteLine("Dados da segunda pessoa:");
            Console.WriteLine("Nome: " + pessoa2.Nome);
            Console.WriteLine("Idade: " + pessoa2.Idade);

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);
            }

        }
    }
}
