using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClassesRetangulo
{
     class Retangulo
    {
        public double Largura;
        public double Altura;


        public double AreaRetangulo()
        {
            return Altura * Largura;
        }

        public double PerimetroRetangulo()
        {
            return 2 * (Altura + Largura);
        }

        public double DiagonalRetangulo()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Largura, 2));
        }


    }
}
