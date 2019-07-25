using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public class CalculadoraOperadores
    {
        public int CalculadoraSomar (int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        public int CalculadoraDiminuir(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public int CalculadoraMultiplicar(int valor1, int valor2)
        {
            return valor1 * valor2;
        }

        public int CalculadoraDuvidir(int valor1, int valor2)
        {
            return valor1 / valor2;
        }
    }
}
