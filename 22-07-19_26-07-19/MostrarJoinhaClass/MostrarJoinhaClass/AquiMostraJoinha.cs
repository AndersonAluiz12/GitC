using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarJoinhaClass
{
    /// <summary>
    /// Será que é sexta hoje
    /// </summary>
    public class AquiMostraJoinha
    {
        public void MetodoInicialdoJoinha()

        {
            Console.WriteLine("Aqui iniciamos o nosso joinha.");

            Console.ReadKey();
        }
        /// <summary>
        /// Aqui ainda não bebe mais que eu!!!
        /// </summary>
        /// <param name="eQuinta"2.0 ainda faz 3 por 1></param>
        public void MetodoDoisPontoZero(bool eQuinta)
        {
            if (eQuinta)
                Console.WriteLine("Carai mermão!!");
            else
                Console.WriteLine("Aiaii!!!");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que vamos identificar o tipo
        /// </summary>
        /// <returns>Retorna algo ??</returns>
        public string [] TesteUmOperadorLegal()
        {
            return new string[2]{ "Teste 1","Teste 2"};
        }
    }
}
