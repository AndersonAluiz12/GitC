using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoCeSharp.Classes
{
    class Conta
    {
        double saldo = 0;

        public Conta()
        {
            //Bonus de mil reais pra iniciar a operar Daytrade
            saldo = 1000;
        }

        public bool Sacar (double valor)
        {
            if(valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            return false;
        }

        public double MostrarSaldo()
        {
            return saldo;
        }
    }
}
