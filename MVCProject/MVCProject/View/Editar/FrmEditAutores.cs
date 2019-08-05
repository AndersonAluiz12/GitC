using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View.Editar
{
    public partial class FrmEditAutores : Form
    {
        public FrmEditAutores()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.AutoresRow AutoresRow;

        private void BtSave_Click(object sender, EventArgs e)
        {
            AutoresRow.Nome_ = txtNome.Text;
            AutoresRow.Descricao = txtDesc.Text;
        }
    }
}
