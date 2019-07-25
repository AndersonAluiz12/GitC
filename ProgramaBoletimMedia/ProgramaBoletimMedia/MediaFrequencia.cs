using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaBoletimMedia
{
    public class MediaFrequencia
    {
        public double MediaAluno (double nota1 , double nota2 , double nota3)
        {
            var Media = ((nota1 + nota2 + nota3) / 3);
            return Media;
        }

        public double FreqAluno(int Aulas, int Faltas)
        {
            var PercFrequencia = ((Aulas - Faltas)*100) / Aulas;
            return PercFrequencia;
        }

        public void ImprimeResult (double MediaResult, double FrequenciaResult )
        {
            if ((MediaResult >=7) && (FrequenciaResult >= 75))
            {
                Console.WriteLine($"A Média: {MediaResult.ToString("F")} com a frequencia: {FrequenciaResult} Aprovado");
            }
            else
            {
                Console.WriteLine($"A Média: {MediaResult.ToString("F")} com a frequencia: {FrequenciaResult} Reprovado");
            }
        }

        public string ImprimeTotal(double MediaResult, double FrequenciaResult)
        {
            if ((MediaResult >= 7) && (FrequenciaResult >= 75))
            {
                return "Aprovado";
            }
            return "Reprovado";            
        }

    }
}
