using System;


namespace ExercicioWhileSenha
{

    class Program
    {


        static void Main(String[] args)
        {

            Console.WriteLine("Digite a senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2000)
            {
                Console.WriteLine("Senha invalida... Digite novamente");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Senha correta. Acesso permitido!");






        }



    }


}