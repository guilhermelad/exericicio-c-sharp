﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClassesMedia
{
    internal class Aluno
    {

        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;


        public double NotaFinal() { 
        
            return Nota1 + Nota2 + Nota3;
        
        }

        public bool Aprovado()
        {
            if (NotaFinal() > 60)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (NotaFinal() > 60) {

                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }






    }
}
