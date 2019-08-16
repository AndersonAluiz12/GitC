using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadora;

namespace AcessoCalculadoraDLL06
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacoes Teste = new Operacoes();
            Console.WriteLine("===============================================");
            Console.WriteLine("==============Calculos Matematico==============");
            Console.WriteLine("===============================================");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"A Resultado da Soma é : {(Teste.CalculaAdicao(1, 2))} !");
            Console.ReadKey();
            Console.WriteLine($"O Resultado Do Retangulo é : {Teste.CalculaAreaRetangulo(1,2,3)} !");
            Console.ReadKey();
            Console.WriteLine($"O Resultado Da divisão é : {Teste.CalculaDivisao(10, 2)} !");
            Console.ReadKey();
            Console.WriteLine($"O Resultado Da Multiplicação é : {Teste.CalculaMultiplicacao(2, 8)} !");
            Console.ReadKey();
            Console.WriteLine($"O Resultado Da Subtração é : {Teste.CalculaSubtracao(2, 3)} !");
            Console.ReadKey();
            Console.WriteLine($"O Resultado Do Triangulo Equilatero é  :{Teste.CalculoTrianguloEquilatero(2, 3)} !");
            Console.ReadKey();
            Console.WriteLine($"O Resultado Do Raio do Circulo é : {Teste.RaioDeUmCirculo(2)} !");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Parabéns , Todos os Calculos Estavam Corretos!");

        }
    }
}
