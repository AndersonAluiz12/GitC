using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var BIbliotecaDoFelipe = new GetFiles();
            string[] Lista = BIbliotecaDoFelipe.RetornaArquivosDoMeuDocumentos();

            for (int i = 0; i < Lista.Length; i++)
            {
                Console.WriteLine(Lista[i]);
            }

            
            string[] ListaGit = BIbliotecaDoFelipe.RetornaArquivosGit();

            for (int i = 0; i < ListaGit.Length; i++)
            {
                Console.WriteLine(ListaGit[i]);
            }

            string[] ListaImage = BIbliotecaDoFelipe.RetornaArquivosImagesFiles();

            for (int i = 0; i < ListaImage.Length; i++)
            {
                Console.WriteLine(ListaImage[i]);
            }

            Console.ReadKey();
          
        }
    }
}
