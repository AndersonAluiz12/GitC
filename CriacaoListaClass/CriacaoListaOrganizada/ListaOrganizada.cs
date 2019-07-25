using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoListaClass.CriacaoListaOrganizada
{
    class ListaOrganizada
    {
        string[] listaNova;
        public void CarregaLista()
        {
            listaNova = new string[10];

            for (int i = 0; i < listaNova.Length; i++)
            {
                listaNova[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
            }
        }

        public void LimpaLista()
            
        {
            Console.WriteLine("Limpando Itens.. :");
            for (int i = 0; i < listaNova.Length; i++)
                listaNova[i] = string.Empty;
            Console.ReadKey();
        }
        public void Listar()
        {
            Console.WriteLine("Listando Itens.. :");
            foreach (var item in listaNova)
                Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}
