using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Receita_de_Bolo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] IngredienteReceita = new string[14]
                {
                    "2 cenouras",
                    "3 ovos",
                    "1/3 de xícara (chá) de óleo",
                    "1 xícara (chá) de açúcar",
                    "1 e 1/3 de xícara (cha) de farinha de trigo",
                    "1/2 colher (sopa) de fermento em po",
                    "1 pitada de sal",
                    "Modo de Preparo:",
                    "Bata a cenoura com os ovos",
                    "Ponha o óleo e o açúcar no liquidificador até ficar homogêneo",
                    "Transfira para uma tigela",
                    "As poucos agregue a farinha misturada com o fermento e o sal",
                    "Asse em forno médio preaquecido (180°C) por cerca de 20 minutos",
                    "Deixe amornar um pouco e desenformar"};

            Console.WriteLine("== Receita de bolo de Cenoura ==");
            Console.WriteLine("== Ingredientes / Modo de Preparo ==");

            for (int i = 0; i < IngredienteReceita.GetLength(0); i++)
            {
                Console.ReadKey();
                Console.WriteLine($"{i+1}°Ingrediente: {IngredienteReceita[i]}");  
            }
        }
       
    }
}
