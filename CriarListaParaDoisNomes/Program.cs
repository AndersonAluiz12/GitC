using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriarListaParaDoisNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] ListaDeCarros = new string[2,5];
            int IdCarros = 0;

            InserirNovoCarro(ref ListaDeCarros, ref IdCarros);

            Console.ReadKey();

            InserirNovoCarro(ref ListaDeCarros, ref IdCarros);
        }

        public static void InserirNovoCarro (ref string[,] ListaDeCarros, ref int IdCarros)
        {
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (ListaDeCarros[i, 0] != null)
                    continue;

                Console.WriteLine("\r\nInforme o nome do Carro:");
                var nomeCarro = Console.ReadLine();

                ListaDeCarros[i, 0] = (IdCarros++).ToString();
                ListaDeCarros[i, 1] = nomeCarro;

                Console.WriteLine("Informe ano do Carro:");
                var anoCarro = Console.ReadLine();

                ListaDeCarros[i, 2] = anoCarro;

                Console.WriteLine("Deseja inserir um novo Carro? sim(1) ou não(0)");
                var continuar = Console.ReadKey().KeyChar.ToString();
                if (continuar == "0")
                    break;

                AumentaListaCarro(ref ListaDeCarros);
            }

            Console.WriteLine("Carro Adicionado com sucesso, segue lista de Carros adicionados:");

            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
                Console.WriteLine(string.Format("Reg.ID {0} - Carro:{1} - Ano:{2}", ListaDeCarros[i, 0], ListaDeCarros[i, 1], ListaDeCarros[i, 2]));

        }

        public static void AumentaListaCarro(ref string[,] ListaDeCarros)
        {
            var LimiteDoCarro = true;
            for (int i = 0; i < ListaDeCarros.GetLength(0); i++)
            {
                if (ListaDeCarros[i, 0] == null)
                    LimiteDoCarro = false;
            }  
            if (LimiteDoCarro)
            {
                var CarroCopia = ListaDeCarros;
                ListaDeCarros = new string[ListaDeCarros.GetLength(0) + 3, 2];

                for (int i = 0; i < CarroCopia.GetLength(0); i++)
                {
                    ListaDeCarros[i,0] = ListaDeCarros[i,0];
                    ListaDeCarros[i,1] = ListaDeCarros[i,1];
                }

                Console.WriteLine("\r\nO tamanho da lista de carros foi aumentada.");
                Console.WriteLine($"\r\nA Nova lista de carros contem {ListaDeCarros.GetLength(0)} espaços e {ListaDeCarros.GetLength(1)} estão ocupados.");
            }
        }
    }
}
