using Listar_meus_carros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_meus_carros
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Carros> minhaLista = new List<Carros>();

            Console.WriteLine("Informe o Modelo / Ano / Placa e CV's do Veiculo:");

            MostraMenu();
            for (int i = 0; i < 5; i++)
                minhaLista.Add(new Carros()
                {
                    Modelo = Console.ReadLine(),
                    Ano = int.Parse(Console.ReadLine()),
                    Placa = (Console.ReadLine()),
                    CV = int.Parse(Console.ReadLine())
                }) ;

            foreach (Carros atributo in minhaLista)
                Console.WriteLine($"Mome: {atributo.Modelo}, Ano: {atributo.Ano}, Placa: {atributo.Placa}, CV: {atributo.CV}. ");

            /*
            foreach (Carros atributo in minhaLista)
                Console.WriteLine($"Lanches Disponiveis: {atributo.Modelo}");

            Console.ReadKey();
            */
        }

        public static void MostraMenu()
        {
            Console.Clear();
            Console.WriteLine("----------Menu De Opções----------");
            Console.WriteLine("1-                  Adiciona Carro");
            Console.WriteLine("2-                    Lista Carros");
            Console.WriteLine("------Escolha uma das opções:-----");

            int.Parse(Console.ReadLine());
        }
    }
}
