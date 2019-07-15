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

            //Usando um laço simples para colocar valores mas no mesmo agora utilizando
            //GetLength com o paramentro "0" para indicar que queremos o tamanho da primera coluna
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                //Carregamdo o que podemos chamar de ID, identificador do nosso registro unico
                listaDeNome[0,0] = i.ToString();
                //Aqui apenas adicionamos uma informação extra 
                listaDeNome[i, 1] = $"Felipe_{i}";
            }

            //Lembrando que GetLength é um metodo e usamos "(parametro" com parametro ou as vezes sem
            //para realizar a chamada do mesmo
            for (int i = 0; i < listaDeNome.GetLength(0); i++)
            {
                // Formatamos uma string de maneira que os dados sejam apresentados
                Console.WriteLine($"ID:{listaDeNome[i, 0]} - Nome:{listaDeNome[i, 1]}");

                Console.ReadKey();
            }
        }
    }
}
