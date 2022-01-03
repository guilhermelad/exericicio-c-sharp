using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioPooBanco
{
     class ContaBancaria
    {
        public string Titular { get; set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; }

        public ContaBancaria(string nome, int numero)
        {
            Titular = nome;
            Numero = numero;
            
        }

        public ContaBancaria(int numero, string nome, double saldo) : this(nome, numero)
        {
            Saldo = saldo;
        }

        public void Deposito(double valor)
        {
            Saldo = Saldo + valor;
        }

        public void Saque(double valor)
        {
            Saldo = Saldo - valor - 5.00;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }


        




    }
}
