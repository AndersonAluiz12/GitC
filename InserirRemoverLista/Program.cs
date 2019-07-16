using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InserirRemoverLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criamos a nossa base de dados inicial
            string[,] baseDedados = new string[2, 5];
            //Indicador dos registros realizados em nosso sistema
            int IndiceBaseDeDados = 0;

            // Apresentação inicial do nosso sistema 
            Console.WriteLine("Iniciando sistema de lista Nome e idade.");
            //Criamos a variavel fora para não ser criada novamente
            var escolhaInicial = ApresentaMenuInicial();
            //Loop infinito ate dar problema
            while (true)
            {
                switch (escolhaInicial)
                {
                    // - Insere Informações na lista
                    case "1": { InseriValoresNaLista(ref baseDedados, ref IndiceBaseDeDados); } break;
                    // - Remove informações da lista
                    case "2": { RemoverInformacoes(ref baseDedados); } break;
                    // - Lista as informações da lista
                    case "3": { MonstrarInformacoes(baseDedados); } break;
                    // Menu que mostra apenas registros desativados no sistema
                    case "4": { MonstrarInformacoes(baseDedados, "true"); } break;
                    case "5":
                        {
                            //Return dentro do nosso caso de escolha ele sai do nosso metodo principal ou
                            //metodo que estamos dentro de contexto
                            return;
                        }
                }
                // Alimento a escolha novamente
                escolhaInicial = ApresentaMenuInicial();
            }
        }
        /// <summary>
        /// Apresenta as informações do menu inicial;
        /// </summary>
        /// <returns>Retorna o menu escolhido.</returns>
        public static string ApresentaMenuInicial()
        {
            //Emtrou no menu inicial inicializa a limpeza
            Console.Clear();
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Inserir um novo registro.");
            Console.WriteLine("2 - Remover um novo registro.");
            Console.WriteLine("3 - Listar informações.");
            Console.WriteLine("4 - Lista as informações desativadas");
            Console.WriteLine("5 - Sair do sistema.");

            Console.WriteLine("Digite o número da opção desejada:");
            //retorna diretamente o menu escolhido.
            return Console.ReadLine();
        }
        /// <summary>
        /// Metodo que insere informações dentro da base de dados
        /// </summary>
        /// <param name="baseDeDados">Base de dados como ref para alterar para todos os metodos</param>
        /// <param name="IndiceBaseDeDados">Indice da nossa base como red para alterar para todos os metodos</param>
        public static void InseriValoresNaLista(ref string[,] baseDeDados, ref int IndiceBaseDeDados)
        {
            Console.WriteLine("----------Inserindo valores na lista---------");

            Console.WriteLine("Informe um nome:");
            var nome = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            var idade = Console.ReadLine();

            //Aumenta o tamanho da nossa lista quando chegar no limite.
            AumentaTamanhoLista(ref baseDeDados);

            //Iniciamos o laço de repetição para varrer nossa base de dados
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                if (baseDeDados[i, 0] != null)
                    continue;
                //Identificamos de maneira unica nosso registro " (" e ")" garante que ele incremente primeiro
                //antes de fazer a conversão para string
                baseDeDados[i, 0] = (IndiceBaseDeDados++).ToString();
                //Carregamos na segunda coluna o valor da idade
                baseDeDados[i, 1] = nome;
                //Carregamos na terceira coluna o valor da idade
                baseDeDados[i, 2] = idade;
                //Carrega a coluna que identifica se o registro está ativo
                baseDeDados[i, 3] = "true";
                //Identificamos agora a data e hora de criação dos registros do sistema
                baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                //Finalizamos aqui para apenas inserir um registro por vez
                break;
            }
            //Informamos para o usuário que finalizou o registro e agora o mesmo irá voltar para o menu inicial
            Console.WriteLine("Registro cadastrado com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial, basta apertar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Montras as informações dentro da nossa lista de dados "base de dados"
        /// </summary>
        /// <param name="baseDeDados">base de dados para a leitura e mostrar pro usuario</param>
        public static void MonstrarInformacoes(String[,] baseDeDados, string mostrarRegistrosNAtivos = "false")
        {
            //Informamos em que tela o mesmo esta
            Console.WriteLine("Apresentação das informações dentro da base de dados.");
            //Comparação que identifica visualmente quais registros estamos mostrando
            if (mostrarRegistrosNAtivos == "true")
                Console.WriteLine("Registros desativados dentro do sistema");
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Aqui deixamos de mostrar as informações que foram desabilitadas dentro do sistema
                if(baseDeDados[i,3] != mostrarRegistrosNAtivos)
                Console.WriteLine($"ID {baseDeDados[i,0]}" +
                        $" - Nome : {baseDeDados[i,1]} " +
                        $" - Idade : {baseDeDados[i,2]}" +
                        $" - Data Alteração: {baseDeDados[i,4]}");

            }
            //Finalizamos a operação e indicamos que não existe mais operações a serem realizadas em 
            //nosso metodo
            Console.WriteLine("Resultados apresentados com sucesso!");
            Console.WriteLine("Para voltar ao menu inicial informar qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo utilizado para remover um registro pelo id dentro do sistema
        /// </summary>
        /// <param name="baseDeDados">Base de dados em que ele ira remover o registro pelo ID</param>
        public static void RemoverInformacoes(ref string[,] baseDeDados)
        {
            Console.WriteLine("Area de remocao de registro do sistema");

            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Identifica que so deve remover os valores ativos dentro do sistema
                if (baseDeDados[i, 3] != "false")
                    Console.WriteLine($"- ID:{baseDeDados[i, 0]} " +
                                      $"- Nome:{baseDeDados[i, 1]} " +
                                      $"- Idade:{baseDeDados[i, 2]}");
            }
            //Indicamos para usuario informar um id dentro do nosso sistema para remover
            Console.WriteLine("Informe o id do registro a ser removido:");
            var id = Console.ReadLine();
            //outro laço agora para remover o registro caso o mesmo exista
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Aqui comparamos os registros para validar o id
                //Colocamos um "&&" pois a comparação de um valor string com um valor null
                //pode gerar erro
                if (baseDeDados[i, 0] != null && baseDeDados[i, 0] == id)
                {
                    //Agora trocamos este valor para um identificador string "false"
                    baseDeDados[i, 3] = "false";
                    //Aqui indicamos a data que foi alterado esse registro
                    baseDeDados[i, 4] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            //Finalizamos as operações desta tela
            Console.WriteLine("Operacoes Finalizadas");
            Console.WriteLine("Para retornar ao menu inicial aperte qualquer tecla.");
            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que aumenta as informações disponivel para cadastro dentro da nossa lista
        /// </summary>
        /// <param name="baseDeDados">retorna nossa base de dados</param>
        public static void AumentaTamanhoLista(ref string[,] baseDeDados)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponivel
            for (int i = 0; i < baseDeDados.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "limiteDaLista" para false
                if (baseDeDados[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = baseDeDados;
                //Aqui Limpamos nossa lista antigas e assinamos novamente com uma lista com mais espaços
                baseDeDados = new string[baseDeDados.GetLength(0) + 5, 5];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador unico
                    baseDeDados[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    baseDeDados[i, 1] = listaCopia[i, 1];
                    //A informação da idade foi atualizada
                    baseDeDados[i, 2] = listaCopia[i, 2];
                    //Identificador se o registro esta ativo
                    baseDeDados[i, 3] = listaCopia[i, 3];
                    //Data alteração deste registro
                    baseDeDados[i, 4] = listaCopia[i, 4];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }
        }
    }
}
