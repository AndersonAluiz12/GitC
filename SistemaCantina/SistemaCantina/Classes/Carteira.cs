using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantina.Classes
{
    class Conta
    {
        double saldoCarteira = 0;
        
        public double Saldo { get { return saldoCarteira; } }

        public Conta()
        {
            saldoCarteira = 20;
        }

        public bool DebitarSaldoCarteira(double valor)
        {
            if (valor <= saldoCarteira)
            {
                saldoCarteira -= valor;
                return true;
            }
            return false;
        }
        public int MenuCantina (int opcao)
        {
            Console.WriteLine("------------Cantina------------");
            Console.WriteLine("1 - Coxinha           (R$ 20,00)");
            Console.WriteLine("2 - Risoles           (R$ 05,00)");
            Console.WriteLine("3 - Pastel            (R$ 02,50)");
            Console.WriteLine("-------------------------------");
            int.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public double ComprarCantina(int opcao)
        {
            if (opcao == 1)
            {
                saldoCarteira -= Saldo - 20;
                Console.WriteLine($"Saldo Disponivel {saldoCarteira}");
            }
            return saldoCarteira;
        }

        public double MostraSaldoCarteira()
        {
            return saldoCarteira;
        }

    }
}
