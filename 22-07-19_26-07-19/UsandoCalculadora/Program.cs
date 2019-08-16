using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculadora;

namespace UsandoCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var Calc = new CalculadoraOperadores();

            Console.WriteLine(Calc.CalcularCirculo(5));

            Console.ReadKey();
        }
    }
}
