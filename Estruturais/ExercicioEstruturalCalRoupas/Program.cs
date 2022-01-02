using System;
using System.Globalization;


namespace ExercicioEstruturalCalRoupas
{

    class Program
    {

        static void Main(String[] args)
        {
           
            double resultado = 0;
            int teste = 1;



            while (teste == 1 || teste != 2)
            {

                Console.WriteLine("Digite o código da peça, número de peças e o valor unítário (na mesma linha);");
                string[] vetorA = Console.ReadLine().Split(' ');

                int quanti = int.Parse(vetorA[1], CultureInfo.InvariantCulture);
                double valor = double.Parse(vetorA[2], CultureInfo.InvariantCulture);

                resultado = resultado + (valor * quanti);


                Console.WriteLine("Deseja adicionar mais uma roupas 1 - sim e 2 - não");
                teste = int.Parse(Console.ReadLine());

              
                if (teste == 2)
                {

                    Console.WriteLine("O valor total é de R$: " + resultado.ToString("F2", CultureInfo.InvariantCulture));

                }
                else if (teste != 2 && teste != 1){

                    Console.WriteLine("Digite a opção certa 1 - Sim e 2 - Não");
                    teste = int.Parse(Console.ReadLine());

                }
               



            }

            







        }



    }




}