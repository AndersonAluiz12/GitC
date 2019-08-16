using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] listaDeLivros = new string[2, 2]
                {{"O Pequeno","sim"},{"O Grande","não"}};

            for (int i = 0; i < listaDeLivros.GetLength(0); i++)
            {
                var Nomelivro = listaDeLivros[i,0];
                var disponivel = listaDeLivros[i, 1];

                Console.WriteLine($"Nome do Livro:{Nomelivro} disponivel:{disponivel}.");
                Console.ReadKey();
            }
        }
    }
}
