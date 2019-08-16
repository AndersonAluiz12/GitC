using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaALuguelCarros
{
    class Program
    {
        static string[,] baseDecarros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmcarro();

                if (opcaoMenu == 2)
                    DesalocarUmcarro();

                if (opcaoMenu == 3)
                {
                    MostrarListaDecarros();
                    Console.Read();
                }

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações do inico do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("================================================");
            Console.WriteLine("=        Sistema de alocação de carros.        =");
            Console.WriteLine("================================================");
            Console.WriteLine("=         Criado pelas fabricas  SHELL         =");
            Console.WriteLine("================================================");
        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha do menu.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido no menu.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("Selecione uma das opções abaixo:");
            Console.WriteLine("1 - Alocar um carro.");
            Console.WriteLine("2 - Devolver um carro.");
            Console.WriteLine("3 - Verificar Disponibilidade.");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de carros dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDecarros = new string[2, 3]
            {
                {"celta","2004","sim"},
                {"palio","2008","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um carro pode ser alocado.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro a que será pesquisado</param>
        /// <returns>Retorna true no caso do carro estar livre para alocação.</returns>
        public static bool PesquisacarroParaAlocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDecarros.GetLength(0); i++)
            {
                if (CompararNomes(nomeCarro, baseDecarros[i, 0]))
                {
                    Console.WriteLine($"O carro:{nomeCarro}" +
                          $" pode ser alocado?:{baseDecarros[i, 0]}");

                    return baseDecarros[i, 2] == "sim";
                }
            }

            return false;
        }
        /// <summary>
        /// Metodo para alterar a informação da alocação do carro.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro</param>
        /// <param name="alocar">Valor bool que define se o carro esta ou não está disponivel.</param>
        public static void AlocarCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < baseDecarros.GetLength(0); i++)
            {
                if (CompararNomes(nomeCarro, baseDecarros[i, 0]))
                {
                    baseDecarros[i, 2] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("carro atualizado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo da aplicação do menu 1
        /// </summary>
        public static void AlocarUmcarro()
        {
            MostrarMenuInicialcarros("Alocar um carro:");

            var nomeDoCarro = Console.ReadLine();
            if (PesquisacarroParaAlocacao(nomeDoCarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o carro? para sim(1) para não(0)");

                AlocarCarro(nomeDoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDecarros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de carros atualizada
        /// </summary>
        public static void MostrarListaDecarros()
        {
            Console.WriteLine("\r\nListagem de carros:");

            for (int i = 0; i < baseDecarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDecarros[i, 0]} Disponivel:{baseDecarros[i, 2]}");
            }
        }
        /// <summary>
        /// Metodo usado para desalocar um carro do sistema.
        /// </summary>
        public static void DesalocarUmcarro()
        {
            MostrarMenuInicialcarros("Desalocar um carro:");

            MostrarListaDecarros();

            var nomeDoCarro = Console.ReadLine();
            if (!PesquisacarroParaAlocacao(nomeDoCarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o carro? para sim(1) para não(0)");

                AlocarCarro(nomeDoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDecarros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra o Menu Inicial
        /// </summary>
        /// <param name="operacao"></param>
        public static void MostrarMenuInicialcarros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do carro para realizar a operação:");
        }
        /// <summary>
        /// Metodo que compara duas strings deixando em caixa baixa e removendo os espaços.
        /// </summary>
        /// <param name="primeiro"></param>
        /// <param name="segundo"></param>
        /// <returns></returns>
        public static bool CompararNomes(string primeiro, string segundo)
        {
            if (primeiro.ToLower().Replace(" ", "")
                    == segundo.ToLower().Replace(" ", ""))
                return true;

            return false;
        }

    }
}
