using ProgramaBoletimMedia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEscola
{
    class Program
    {
        static void Main(string[] args)
        {
            InseriInformacoesAluno ResultadoFreq = new InseriInformacoesAluno();
            ResultadoFreq.InserirAluno();
            Console.Clear();

            ResultadoFreq.ListarALunos();         
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Informe registro que deseja Alterar");
            int.TryParse(Console.ReadLine(), out int reg);
            ResultadoFreq.AlterarNotas(reg);
            Console.Clear();

            ResultadoFreq.ListarALunos();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Informe registro que deseja Excluir");
            int.TryParse(Console.ReadLine(), out reg);
            ResultadoFreq.ExcluirALunos(reg);
            Console.Clear();

            ResultadoFreq.ListarALunos();
            Console.ReadKey();
        }
    }
}
