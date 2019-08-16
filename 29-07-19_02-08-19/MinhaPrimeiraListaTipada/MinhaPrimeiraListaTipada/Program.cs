using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> o tipo da minha lista com isso temos uma lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();
            //Adiciono na minha lista um pão de queijo

            Console.WriteLine("Informe Nome / Quantidade e Valor :");
            for (int i = 0; i < 5; i++)
                minhaLista.Add(new Lanche()
                {
                    Nome = Console.ReadLine(),
                    Quantidade = int.Parse(Console.ReadLine()),
                    Valor = double.Parse(Console.ReadLine())
                }); ;

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Nome:{item.Nome}, Quant: {item.Quantidade}, val:{item.Valor}.");

            Console.ReadKey();



            /*
            //Aqui ando pela lista para poder apresentar em tela os valores
            //item in significa que ele ja e um indice da minha lista 
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches Disponiveis: {item.Nome} ");

            Console.WriteLine("Removendo Item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 9)
                    minhaLista.Remove(item);
                break;
            }

            /*
            minhaLista.Remove(minhaLista.FirstOrDefault(x => x.Quantidade == 2));

            var meuItem = (from item in minhaLista
                where item.Quantidade == 3
                select item).ToList<Lanche>();
            

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches Disponiveis: {item.Nome}");

            Console.ReadKey();
          */  
       
    }
}
