using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando nossa lista com mais de uma dimensão
            string[,] listaDeNome = new string[5, 2];

            CarregaInformaçoesEListasEmTela(ref listaDeNome);

            // Após carregar as informações e mostrar em tela ele espera um comando
            Console.ReadKey();

            //Indicamos que o usuário precisa informar um numero de identificação para pesquisar um registro.
            Console.WriteLine("Informe um ID do registro a ser pesquisado");
            //Aqui realizamenos a pesquisa somente na chamada
            //Passamos a nossa lista normalmente pois não iremos alterar e apenas pesquisar a informação
            //Após a virgula temos o console realine que espera nosso identificados unico

            PesquisandoInformacoesNaLista(listaDeNome, Console.ReadLine());
            //Usando um laço simples para colocar valores mas no mesmo agora utilizando
            //GetLength com o paramentro "0" para indicar que queremos o tamanho da primera coluna
            Console.ReadKey();
        }

        public static void CarregaInformaçoesEListasEmTela(ref string[,] arrayBi)

        {
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                //Carregamdo o que podemos chamar de ID, identificador do nosso registro unico
                arrayBi[i, 0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra 
                arrayBi[i, 1] = $"Anderson_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro" com parametro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < arrayBi.GetLength(0); i++)
            {
                // Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
            }
        }

        public static void PesquisandoInformacoesNaLista(string[,] arrayBi, string pId)
        {
            for (int i=0;i <arrayBi.GetLength(0);i++)
            {
                if (arrayBi[i,0]== pId)
                {
                    Console.WriteLine($"Informação escolhida: Id {arrayBi[i, 0]} - Nome:{arrayBi[i, 1]}");
                    return;
                }
            }
            Console.WriteLine("Infelizmente a busca pelo id não resultou em nenhuma informação");
        }
     }
}
    