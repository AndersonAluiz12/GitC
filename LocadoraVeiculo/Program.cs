using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alocar_Carro
{
    class Program
    {
        static string[,] baseDeVeiculos;
        static void Main(string[] args)
        {
            CarregaTipoVeiculo();
            MostrarBemVindoAlocacao();
            if (MenuVeiculo() == 1) ;

            {
                MostrarMenuCarroAlocacao();
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra a tela inicial de Alocação
        /// </summary>
        public static void MostrarBemVindoAlocacao()
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("     Alocação de Carros");
            Console.WriteLine("___________________________");
            Console.WriteLine("     Sistema de Locação");
            Console.WriteLine("___________________________");
        }
        /// <summary>
        /// Metodo que mostra as opções para Alocação do Veículo
        /// </summary>
        /// <returns>Retorna o resultado como tipo inteiro</returns>
        public static int MenuVeiculo()
        {
            Console.WriteLine("\r\nMenu Inicial para Alocar Veículo");
            Console.WriteLine("Digite uma das seguintes opções:");
            Console.WriteLine("Digite (1) para Alocar um Veículo");
            Console.WriteLine("Digite (2) para sair do sistema");
            Console.WriteLine("\r\nDigite a opção desejada");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Carrega os tipos de veiculos/ano disponiveis para locação
        /// </summary>
        public static void CarregaTipoVeiculo()
        {
            baseDeVeiculos = new string[2, 3]
            {
                { "Corsa","2006","Não"},
                { "Celta","2004","Sim"}
            };
        }
        /// <summary>
        /// Metodo de retorno que mostra se o carro pode ser alocado.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro para verificar disponibilidade.</param>
        /// <returns>Retorna Verdadeiro se o carro estiver dispivel.</returns>
        public static bool PesquisaCarroParaAlocacao(string nomeCarro, int ano)
        {
            for (int i = 0; i < baseDeVeiculos.GetLongLength(0); i++)
            {
                if (nomeCarro == baseDeVeiculos[i, 0] && ano.ToString() == baseDeVeiculos[i, 1])
                {
                    Console.WriteLine($" Carro:{nomeCarro}" + $"{ano}" + $"pode ser alocado?:{baseDeVeiculos[i, 2]}");

                    return baseDeVeiculos[i, 2] == "Sim";
                }
            }
            return false;
        }
        /// <summary>
        /// Metodo para alocação do veiculo.
        /// </summary>
        /// <param name="nomeCarro">Nome do carro locado.</param>
        public static void AlocarVeiculo(string nomeCarro)
        {
            for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
            {
                if (nomeCarro == baseDeVeiculos[i, 0])
                    baseDeVeiculos[i, 1] = "Não";
            }
        }

        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1.
        /// </summary>
        public static void MostrarMenuCarroAlocacao()
        {
            Console.Clear();

            MostrarBemVindoAlocacao();

            Console.WriteLine("Menu - Alocação de Veiculos");
            Console.WriteLine("Digite o nome do carro a ser alocado:");
            var nomeCarro = Console.ReadLine();
            Console.WriteLine("Digite o ano do carro a ser alocado:");
            string ano = Console.ReadLine();
            int.TryParse(ano, out int resultado);
            if (PesquisaCarroParaAlocacao(nomeCarro, resultado))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar este carro? Para sim (1) para não (0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarVeiculo(nomeCarro);
                    Console.Clear();
                    Console.WriteLine("Carro Alocado com sucesso");
                }
                else
                    Console.Clear();

                Console.WriteLine("Listagem de Carros");

                for (int i = 0; i < baseDeVeiculos.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeVeiculos[i, 0]} Disponivel: {baseDeVeiculos[i, 2]}");
                }
            }
        }
    }
}
