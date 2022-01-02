using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExericicoClasseEstaticaDolar
{
    internal class Conversor
    {

        public static double IOF = 0.06;

        public static double RealDolar(double cotacao, double valor)
        {
            
            return (cotacao * valor) + (cotacao * valor) * IOF;
        }




    }
}
