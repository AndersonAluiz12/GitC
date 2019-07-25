using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBoletimMedia
{
    public class InseriInformacoesAluno
    { 
        string[,] ListaAluno = new string[5, 5];

        MediaFrequencia ResultadoFreq = new MediaFrequencia();

        public void InserirAluno()
        {


            for (int i = 0; i < ListaAluno.GetLength(0); i++)
            {
                Console.WriteLine("Informe o nome do Aluno");
                var nome = Console.ReadLine();
                ListaAluno[i, 0] = i.ToString();
                ListaAluno[i, 1] = nome;

                Console.WriteLine($"Insira a primeira nota: ");
                double.TryParse(Console.ReadLine(), out double nota1);

                Console.WriteLine($"Insira a segunda nota: ");
                double.TryParse(Console.ReadLine(), out double nota2);

                Console.WriteLine($"Insira a terceira nota: ");
                double.TryParse(Console.ReadLine(), out double nota3);

                var media = ResultadoFreq.MediaAluno(nota1, nota2, nota3);
                ListaAluno[i, 2] = media.ToString("F");

                var frequencia = ResultadoFreq.FreqAluno(200, 25);
                ListaAluno[i, 3] = frequencia.ToString();

                ListaAluno[i, 4] = ResultadoFreq.ImprimeTotal(media, frequencia);

                Console.WriteLine($"O aluno : {ListaAluno[i, 1]} atingiu média {ListaAluno[i, 2]}");
                Console.WriteLine($"Com o total de {ListaAluno[i, 3]}% de frequencia, está {ListaAluno[i, 4]}! ");
            }
        }

        public void ListarALunos()
           
        {
            for (int i = 0; i < ListaAluno.GetLength(0); i++)
            {
                if (ListaAluno[i, 1] == "") 
                {
                    continue;
                }

                Console.WriteLine($"ID{ListaAluno[i, 0]}-O aluno :{ListaAluno[i, 1]} atingiu média {ListaAluno[i, 2]}");
                Console.WriteLine($"Com o t" +
                    $"otal de {ListaAluno[i, 3]}% de frequencia, está {ListaAluno[i, 4]}! \n");
            }
        }

        public void ExcluirALunos(int pID)
        {

            for (int i = 0; i < ListaAluno.GetLength(0); i++)
            {
                if (ListaAluno[i, 0] == pID.ToString())
                {
                    ListaAluno[i, 1] = "";
                    ListaAluno[i, 2] = "";
                    ListaAluno[i, 3] = "";
                    ListaAluno[i, 4] = "";
                }
            }       
        }

        public double ReDigitaNotas()
        {
            Console.WriteLine($"Insira a primeira nota: ");
            double.TryParse(Console.ReadLine(), out double nota1);

            Console.WriteLine($"Insira a segunda nota: ");
            double.TryParse(Console.ReadLine(), out double nota2);

            Console.WriteLine($"Insira a terceira nota: ");
            double.TryParse(Console.ReadLine(), out double nota3);

            return ResultadoFreq.MediaAluno(nota1, nota2, nota3);
        }

        public void AlterarNotas(int PiD)
        {
            for (int i = 0; i < ListaAluno.GetLength(0); i++)
            {
                if(ListaAluno[i,0] == PiD.ToString())
                {
                    var media = ReDigitaNotas();
                    ListaAluno[i, 2] = media.ToString();

                    var frequencia = Convert.ToInt32(ListaAluno[i, 3]);
                    ListaAluno[i,4] = ResultadoFreq.ImprimeTotal(media, frequencia);
                }
            }
        }
    }
}
