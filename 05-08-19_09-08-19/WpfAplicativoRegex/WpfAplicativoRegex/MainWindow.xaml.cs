using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WpfAplicativoRegex
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = txtEmail.Text;
            string Telefone = txtNumero.Text;

            var stringRegEmail = "^[\\w!#$%&'*+/=?`{|}~^-]+(?:\\.[\\w!#$%&'*+/=?`{|}~^-]+)*@(?:[a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$";
            var stringRegNumero = @"\d{2}\(\d{2}\)\s\d{4,5}\-\d{4}";

            Regex regf = new Regex(stringRegEmail);
            if (regf.IsMatch(email))
                MessageBox.Show("E-Mail válido");
            else
                MessageBox.Show("E-Mail invalido");
           

            Regex regT = new Regex(stringRegNumero);
            if (regT.IsMatch(Telefone))
                MessageBox.Show("Telefone válido");
            else
                MessageBox.Show("Telefone invalido"); 
        }
    }
}