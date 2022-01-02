using System;


namespace ExercicioCondiDuracaoPartida
{

    class Program
    {

        static void Main(String[] args)
        {
            int resultado;

            Console.WriteLine("Digite a Hora de inicio da partida: ");
            int HoraInicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digita a Hora de termino da partida: ");
            int HoraFim = int .Parse(Console.ReadLine());
            

            if (HoraInicio < HoraFim)
            {
                
               resultado = HoraInicio - HoraFim;



            }
            else
            {

                resultado = 24 - HoraInicio + HoraFim;

            }


            Console.WriteLine("O JOGO DUROU " + resultado + " HORAS");



        }


    }


}
