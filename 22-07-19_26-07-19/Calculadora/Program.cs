using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
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

        public int CalcularRetangulo (int Base1 , int Altura2)
        {
            return Base1 * Altura2;
        }

        public int CalcularTriangulo(int Base1, int Altura2)
        {
            return (Base1 * Altura2) / 2;
        }

        public double CalcularCirculo(int Area)
        {
          
           var raio = Math.Sqrt((Area / 3.14));
            return raio;

        }
    }
}
