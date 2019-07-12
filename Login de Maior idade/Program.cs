using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_de_Maior_idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informa o seu Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Informa a sua idade: ");
            var idade = int.Parse(Console.ReadLine());

            if (idade <18)
                Console.WriteLine("Você não está autorizado a compra de bebidas alcoolicas!");
            else
                 Console.WriteLine("Beba por que você ja esperou tempo demais");

            Console.ReadKey();
            
        }
    }
}
