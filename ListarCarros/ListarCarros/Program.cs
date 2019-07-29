using ListarCarros.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListarCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Carros> minhaLista = new List<Carros>();

            Console.WriteLine("--Sistema Para Listar Carros--");
            Console.WriteLine("Informe Uma das opções abaixo:");
            Console.WriteLine("1 -           Listar os Carros");
            Console.WriteLine("2 -          Adicionar Veiculo");
            Console.ReadKey();



            Console.WriteLine("Informe o Modelo / Ano / Placa e CV's do Veiculo");

            for (int i = 0; i < 3; i++)
                minhaLista.Add(new Carros
                {
                    Modelo = Console.ReadLine(),
                    Ano = int.Parse(Console.ReadLine()),
                    Placa = (Console.ReadLine()),
                    CV = int.Parse(Console.ReadLine())});

            foreach (Carros atributo in minhaLista)

                Console.WriteLine($"Modelo: {atributo.Modelo}, Ano {atributo.Modelo}, Placa {atributo.Placa}, CV {atributo.CV}");
            /*
            foreach (Carros atributo in minhaLista)
                Console.WriteLine($"Lista Carros: {atributo.Modelo}");
            */

            Console.ReadKey();
        }
    }
}
