using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            new AquiMostraJoinha().MetodoInicialdoJoinha();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);
            */

            //Operação pesada como leitura e gravação na memória
            var outroCaraParaRealizarOTEste = new AquiMostraJoinha()
                .TesteUmOperadorLegal();
            //Cibtagen de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizarOTEste.Length;
            //Nosso for agora esta mais rapido
            for (int i = 0; i < tamanhoDaLista; i++)
            {
                Console.WriteLine(outroCaraParaRealizarOTEste[i]);
            }

            Console.Write(new AquiMostraJoinha().TesteUmOperadorLegal());

            Console.ReadKey();
        }
    }
}
