using SistemaCantina.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta aluno = new Conta();

            Console.WriteLine("Informe o Lanche a ser Comprado");
            aluno.MenuCantina();

            Console.ReadKey();

        }
    }
}
