using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Adicionando valores em uma lista
namespace AdicionandoValoresEmUmaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criação da lista
            string[,] listaDeNome = new string[10, 2];
            //Aqui vamos criar uma forma externa de identificar nossos registros
            int IdParalista = 0;

            InsereRegistro(ref listaDeNome, ref IdParalista);

            Console.ReadKey();

            InsereRegistro(ref listaDeNome, ref IdParalista);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que Insere um Novo Registro
        /// </summary>
        /// <param name="listaDeNome">Lista de Nomes vazia ou Não</param>
        /// <param name="IdParalista">Referencia Externa Id</param>
        public static void InsereRegistro(ref string[,] listaDeNome, ref int IdParalista)
        {
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Aqui definimos
                if (listaDeNome[i, 0] != null)
                    continue;
                //Indicamos que ele deve apenas informar o nome do nosso registro
                Console.WriteLine("\r\nInforma um nome para adicionar ao Registro:");
                var nome = Console.ReadLine();
                //Criamos o nosso identificados unico com um objeto externo que
                //mesmo após sairmos do nosso laço ainda podera ser incrementado
                listaDeNome[i, 0] = (IdParalista++).ToString();
                listaDeNome[i, 1] = nome;

                //Identificamos se o mesmo ainda deseja inserir registros dentro de nossa lista
                Console.WriteLine("Deseja inserir um novo registro? sim (1) ou não (0)");
                //O readkey so espera uma unica tecla e nos retorna a tecla que foi acionada e não o valor dela
                //Por isso usamos o Keychar para pegar esse valor e converter ele em um string para comparação
                var continuar = Console.ReadKey().KeyChar.ToString();
                //Aqui validamos a condição se o mesmo deve ou nãõ continuar a adicionar registro até que a nossa
                //lista esteja completa de informações
                if (continuar == "0")
                    break;//Break é uma palavra reservada do c# que para, e por isso breal, todo laço de repetição
                          //ou sequenciador logico o.0.

                AumentaTamanhoLista(ref listaDeNome);
            }

            Console.WriteLine("Registro adicionado com sucesso, segue a lista de informação adiocionada:");

            //Mas agora a coisa muda:
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
                //Utilizamos o string format, basicamente ele faz da mesma forma que o sifrão
                //a diferença entre eles é que este é um cara grandes quantidades
                //acaba sendo mais rápido
                Console.WriteLine(string.Format("Registro ID {0} - Nome:{1}", listaDeNome[i, 0], listaDeNome[i, 1]));
        }

        public static void AumentaTamanhoLista(ref string[,] ListaDeNome)
        {
            //Verifica se precisa criar uma lista maior
            var limiteDaLista = true;
            //Laço que verifica se existe registro disponivel
            for (int i = 0; i < ListaDeNome.GetLength(0); i++)
            {
                //Caso ainda existir registro disponivel ele seta nossa variavel "limiteDaLista" para false
                if (ListaDeNome[i, 0] == null)
                    limiteDaLista = false;
            }

            //Caso não tenha mais registro nossa variavel ficou como true então indica que precisamos aumentar nossa lista
            if (limiteDaLista)
            {
                //criamos uma cópia da nossa lista para não perder os valores
                var listaCopia = ListaDeNome;
                //Aqui Limpamos nossa lista antigas e assinamos novamente com uma lista com mais espaços
                ListaDeNome = new string[ListaDeNome.GetLength(0) + 5, 2];
                //Agora copiamos os registros da nossa lista antiga e passamos para a nossa nova lista
                for (int i = 0; i < listaCopia.GetLength(0); i++)
                {
                    //Copiamos a informação do identificador unico
                    ListaDeNome[i, 0] = listaCopia[i, 0];
                    //Copiamos a informação do nosso nome
                    ListaDeNome[i, 1] = listaCopia[i, 1];
                }
                //indicamos que neste ponto a lista foi atualizada em seu tamanho.
                Console.WriteLine("O tamanho da lista foi atualizado.");
            }

        }

    }
}
