using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoMarcacs : Form
    {
        public frmEdicaoMarcacs()
        {
            InitializeComponent();
        }


        public DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow MarcasRow;

        private void FrmEdicaoMarcacs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.Fill(this.querysInnerJoinDataSet1.Marcas);

            txtNome.Text = MarcasRow.Nome;

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            MarcasRow.Nome = txtNome.Text;

            this.Close();
        }
    }
}
