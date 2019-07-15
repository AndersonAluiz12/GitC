using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoListaNova
{
    class Program
    {
        static void Main(string[] args)
        {
            //1°  Criação de lista com string linear
            string[] lista = new string [10]; // definição do numero de posições da lista iniciando em 10
            // espaço na memoria para alogar a informações de texto
            for (int i = 0; i <  lista.Length; i++)
            {
                //carrega valores da lista
                // aonde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                // DateTime é um tipo do .net c# que disponibiliza funções relacionadas a datas
                // e horas, ou seja se precisar trabalhar com essas informações é possivel utiliza-lo.
            }
            // laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista) // "var item" indica uma unidade da nossta lista "in lista"
                // indica a lista que desejamos varrer
                Console.WriteLine(item); // aqui apresentamos essa informação na tela

            Console.ReadKey();

            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty; //aqui limpamos o nosso valor dentro da coleção

            // laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista) // "var item" indica uma unidade da nossta lista "in lista"
                // indica a lista que desejamos varrer
                Console.WriteLine(item); // aqui apresentamos essa informação na tela

            Console.ReadKey();

        }
    }
}
