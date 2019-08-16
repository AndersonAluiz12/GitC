using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinalConsoleBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] baseDadosBiblioteca = new string[2, 5];
            int RegistroBaseDados = 0;

            Console.WriteLine("Sistema novo da Biblioteca");

            var EscolhaLivro = MenuBiblioteca();

            while (true)
            {
                switch (EscolhaLivro)
                {

                    case "1": { InseriLivroBiblioteca(ref baseDadosBiblioteca, ref RegistroBaseDados); } break;

                    case "2": { ApagarLivro(ref baseDadosBiblioteca); } break;

                    case "3": { MostrarInfLivro(baseDadosBiblioteca); } break;

                    case "4": { MostrarInfLivro(baseDadosBiblioteca, "true"); } break;

                    case "5": { return; } ;

                }
                // Alimento a escolha novamente
                EscolhaLivro = MenuBiblioteca();
            }
        }
        /// <summary>
        /// Informações do Menu da Biblioteca
        /// </summary>
        /// <returns>Retorna a opção selecionada</returns>
        public static string MenuBiblioteca()

        {
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("========Menu Biblioteca==========");
            Console.WriteLine("=================================");
            Console.WriteLine("=  1 - Inserir Livro            =");
            Console.WriteLine("=  2 - Apagar Livro             =");
            Console.WriteLine("=  3 - Listar Livros            =");
            Console.WriteLine("=  4 - Listar Livros Apagados   =");
            Console.WriteLine("=  5 - Sair do sistema.         =");
            Console.WriteLine("=================================");
            Console.WriteLine("==Escolha uma das opções Acima:==");
            Console.WriteLine("=================================");
            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que Insere valores na baseDadosBiblioteca
        /// </summary>
        /// <param name="baseDadosBiblioteca">Base referencia para todos os metodos</param>
        /// <param name="RegistroBaseDados">Indice referencia para todos os metodos</param>
        public static void InseriLivroBiblioteca(ref string[,] baseDadosBiblioteca, ref int RegistroBaseDados)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("======== Insira um Livro ========");
            Console.WriteLine("=================================");


            Console.WriteLine("====Informe o nome do Livro:=====");

            var nome = Console.ReadLine();

            Console.WriteLine("====Informe o autor do Livro=====");
            var autor = Console.ReadLine();

            AumentaTamanhoListaLivros(ref baseDadosBiblioteca);

            for (int i = 0; i < baseDadosBiblioteca.GetLength(0); i++)
            {
                if (baseDadosBiblioteca[i, 0] != null)
                    continue;
                baseDadosBiblioteca[i, 0] = (RegistroBaseDados++).ToString();
                baseDadosBiblioteca[i, 1] = nome;
                baseDadosBiblioteca[i, 2] = autor;
                baseDadosBiblioteca[i, 3] = "true";
                baseDadosBiblioteca[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                break;
            }

            Console.WriteLine("Livro cadastrado com sucesso!");
            Console.WriteLine("Retorne ao menu inicial, apertando qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Mostras as informações dos livros que já estão cadastrados / não apagados
        /// </summary>
        /// <param name="baseDadosBiblioteca">Mostra a base de dados que esta disponivel</param>
        /// <param name="mostraLivrosNAtivos">Mostras a base de livros apagados</param>
        public static void MostrarInfLivro(String[,] baseDadosBiblioteca, string mostraLivrosNAtivos = "false")
        {
            
            Console.WriteLine("Apresenta informações da base de Livros.");
            if (mostraLivrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema");
            for (int i = 0; i < baseDadosBiblioteca.GetLength(0); i++)
            {
                if (baseDadosBiblioteca[i, 3] != mostraLivrosNAtivos)
                    Console.WriteLine($"ID {baseDadosBiblioteca[i, 0]}" +
                            $" - Nome : {baseDadosBiblioteca[i, 1]} " +
                            $" - Autor : {baseDadosBiblioteca[i, 2]}" +
                            $" - Data Alteração: {baseDadosBiblioteca[i, 4]}");
        }  
            Console.WriteLine("Resultado dos Livros");
            Console.WriteLine("Para voltar pressione qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo usado para apagar livros do sistema
        /// </summary>
        /// <param name="baseDadosBiblioteca">Base de onde será solicitado um ID para apagar o livro</param>
        public static void ApagarLivro (ref string[,] baseDadosBiblioteca)
        {
            Console.WriteLine("Apagar um livro do sistema");
           
            for (int i = 0; i < baseDadosBiblioteca.GetLength(0); i++)
            {
                if (baseDadosBiblioteca[i, 3] != "false")
                    Console.WriteLine($"- ID: {baseDadosBiblioteca[i, 0]}" +
                                      $"- Nome: {baseDadosBiblioteca[i, 1]}" +
                                      $"- Autor: {baseDadosBiblioteca[i, 2]}");                                   
            }
            Console.WriteLine("Informe o ID do livro que será removido:");
            var identificador = Console.ReadLine();
            for (int i = 0; i < baseDadosBiblioteca.GetLength(0); i++)
            {
                if (baseDadosBiblioteca[i,0] != null && baseDadosBiblioteca[i,0] == identificador)
                {
                    baseDadosBiblioteca[i, 3] = "false";
                }
            }

            Console.WriteLine("Livro removido");
            Console.WriteLine("Pressione qualquer tecla para voltar");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo para aumentar o numro maximo de livros cadastrados
        /// </summary>
        /// <param name="baseDadosBiblioteca">Retorna a base de dados </param>
        public static void AumentaTamanhoListaLivros(ref string[,] baseDadosBiblioteca)
        {
        
            var limiteDaLista = true;
            for (int i = 0; i < baseDadosBiblioteca.GetLength(0); i++)
            {
                if (baseDadosBiblioteca[i, 0] == null)
                    limiteDaLista = false;
            }

            if (limiteDaLista)
            {
                var listaCopia = baseDadosBiblioteca;
                baseDadosBiblioteca = new string[baseDadosBiblioteca.GetLength(0) + 5, 5];
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    baseDadosBiblioteca[i, 0] = listaCopia[i, 0];
                    baseDadosBiblioteca[i, 1] = listaCopia[i, 1];
                    baseDadosBiblioteca[i, 2] = listaCopia[i, 2];
                    baseDadosBiblioteca[i, 3] = listaCopia[i, 3];
                    baseDadosBiblioteca[i, 4] = listaCopia[i, 4];
                }

                Console.WriteLine("O tamanho da lista de livros foi atualizada.");
            }
        }
    }
}
