using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listar_20_Alunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("               Lista de Alunos");
            Console.WriteLine("==============================================");
            Console.WriteLine("    Pressione a tecla (Enter) para exibir:");
            Console.WriteLine("==============================================\r\n");
            Console.ReadKey();

            string[,] ListaDeAlunos = new string[20, 3]
            {
            {"Andy","19","Masculino"},
            {"Endy","21","Masculino"},
            {"Indi","23","Feminino"},
            {"Ondw","18","Masculino"},
            {"Alies","15","Feminino"},
            {"Pedro","19","Feminino"},
            {"Bruna","19","Masculino"},
            {"Maicon","21","Masculino"},
            {"Rafael","23","Feminino"},
            {"Ricardo","18","Masculino"},
            {"Bruno","15","Feminino"},
            {"Serial","19","Feminino"},
            {"Jonas","19","Masculino"},
            {"Udo","21","Masculino"},
            {"Erick","23","Feminino"},
            {"Gilberto","18","Masculino"},
            {"Tomas","15","Feminino"},
            {"Janete","19","Feminino"},
            {"Alecir","15","Feminino"},
            {"Luiz","19","Feminino"}
            };

            for (int i = 0; i < ListaDeAlunos.GetLength(0); i++)
            {
                Console.WriteLine($"{i + 1}° Aluno: {ListaDeAlunos[i, 0]}, Idade: {ListaDeAlunos[i, 1]}, Sexo: {ListaDeAlunos[i, 2]} ");              
            }
            Console.ReadKey();
        }
    }
}
