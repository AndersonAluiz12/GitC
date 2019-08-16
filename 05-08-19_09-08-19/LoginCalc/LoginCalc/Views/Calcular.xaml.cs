using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginCalc.Views
{
    /// <summary>
    /// Interaction logic for Calcular.xaml
    /// </summary>
    public partial class Calcular : UserControl
    {

        int numero1 = 0;
        int numero2 = 1;
        string Operacao = "";

        public Calcular()
        {
            InitializeComponent();
        }

        private void Botao1_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 1;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                VisorResultado.Text = numero2.ToString();
            }
        }

        private void Botao2_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 2;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                VisorResultado.Text = numero2.ToString();
            }
        }

        private void Botao3_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 3;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                VisorResultado.Text = numero2.ToString();
            }
        }


        private void Botao4_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 4;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                VisorResultado.Text = numero2.ToString();
            }
        }
        private void Botao5_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 5;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                VisorResultado.Text = numero2.ToString();
            }
        }

        private void Botao6_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 6;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                VisorResultado.Text = numero2.ToString();
            }
        }

        private void Botao7_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 7;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                VisorResultado.Text = numero2.ToString();
            }
        }

        private void Botao8_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 8;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                VisorResultado.Text = numero2.ToString();
            }
        }

        private void Botao9_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 9;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                VisorResultado.Text = numero2.ToString();
            }

        }

        private void Botao0_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 * 10) + 0;
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 * 10) + 0;
                VisorResultado.Text = numero2.ToString();
            }
        }


        private void Somar_Click(object sender, RoutedEventArgs e)
        {
            Operacao = "+";
            VisorResultado.Text = "0";
        }

        private void Subtrair_Click(object sender, RoutedEventArgs e)
        {
            Operacao = "-";
            VisorResultado.Text = "0";
        }

        private void Multiplicar_Click(object sender, RoutedEventArgs e)
        {
            Operacao = "*";
            VisorResultado.Text = "0";
        }

        private void Dividir_Click(object sender, RoutedEventArgs e)
        {
            Operacao = "/";
            VisorResultado.Text = "0";
        }

        private void Resultado_Click(object sender, RoutedEventArgs e)
        {
            switch (Operacao)
            {
                case "+":
                    VisorResultado.Text = (numero1 + numero2).ToString();
                    break;
                case "-":
                    VisorResultado.Text = (numero1 - numero2).ToString();
                    break;
                case "*":
                    VisorResultado.Text = (numero1 * numero2).ToString();
                    break;
                case "/":
                    VisorResultado.Text = (numero1 / numero2).ToString();
                    break;
            }
        }

        private void Limpar_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = 0;
                VisorResultado.Text = "0";
            }
            else
            {
                numero2 = 0;
            }
            VisorResultado.Text = "0";
        }

        private void Apagar_Click(object sender, RoutedEventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            Operacao = "";
            VisorResultado.Text = "0";

        }

        private void BotaoBUM_Click(object sender, RoutedEventArgs e)
        {
            Window1 tela = new Window1();
            tela.Show();
        }

        private void BotaoSair_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BotaoApagar_Click(object sender, RoutedEventArgs e)
        {
            if (Operacao == "")
            {
                numero1 = (numero1 / 10);
                VisorResultado.Text = numero1.ToString();
            }
            else
            {
                numero2 = (numero2 / 10);
                VisorResultado.Text = numero2.ToString();
            }
        }
    }
}
