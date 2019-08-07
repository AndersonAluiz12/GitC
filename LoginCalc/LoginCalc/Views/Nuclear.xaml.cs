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
    /// Interaction logic for Nuclear.xaml
    /// </summary>
    public partial class Nuclear : UserControl
    {
        public event EventHandler BOOM;
        public Nuclear()
        {
            MessageBox.Show("Click em 'OK' Para ativação dos Mísseis");
            InitializeComponent();
            
        }
    }
}
