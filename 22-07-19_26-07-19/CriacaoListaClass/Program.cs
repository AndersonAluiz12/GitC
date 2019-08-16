using CriacaoListaClass.CriacaoListaOrganizada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoListaClass
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaOrganizada obj = new ListaOrganizada();
            obj.CarregaLista();
            obj.Listar();
            obj.LimpaLista();
            obj.Listar();
        }
    }
}
