using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca
{
    class Program
    {

        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();

            if (MenuInicial() == 1)
            {
                MostrarMenuAlocacao();
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra a informação inicial p/ locação de um livro.
        /// </summary>
        public static void  MostrarSejaBemVindo ()
        {
            Console.WriteLine("__________________________________________");
            Console.WriteLine("        Sistema de Locação de Livros");
            Console.WriteLine("__________________________________________");
            Console.WriteLine("   Desenvolvido pelas industrias NSA");
            Console.WriteLine("__________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o conteudo do menu e as opções de escolha.
        /// </summary>
        /// <returns>Retorna o valor do menu escolhido em um tipo inteiro.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do Sistema.");
            Console.WriteLine("Digite o Número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados do Sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O Pequeno","sim" },
                {"O Grande", "não" }
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado.</param>
        /// <returns>Retorna verdadeiro em caso do livro estar livre para alocação.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLongLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O Livro:{nomeLivro}" +
                        $" pode ser alocado?:{baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }

            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1.
        /// </summary>
        public static void MostrarMenuAlocacao()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Alocação de Livros");
            Console.WriteLine("Digite o nome do livro a ser alocado:");

            var nomedolivro = Console.ReadLine();
            if (PesquisaLivroParaAlocacao(nomedolivro))
            {
                Console.Clear();
                Console.WriteLine("Você deseja alocar o livro? Para sim (1) para não (0)");
                if (Console.ReadKey().KeyChar.ToString() == "1")
                {
                    AlocarLivro(nomedolivro);
                    Console.Clear();
                    Console.WriteLine("Livro Alocado com sucesso");
                }
                else
                    Console.Clear();

                Console.WriteLine("Listagem de Livros");

                for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                {
                    Console.WriteLine($"Nome: {baseDeLivros[i, 0]} Disponivel: {baseDeLivros[i, 1]}");
                }
            }
        }
    }
}
