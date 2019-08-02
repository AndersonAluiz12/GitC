using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicao
{
    public partial class frmAddVendas : Form
    {
        public frmAddVendas()
        {
            InitializeComponent();
        }

        public Vendas VendasRow;

        private void BtAdiciona_Click(object sender, EventArgs e)
        {
            var valor = decimal.Parse(txtValue.Text);

            VendasRow = new Vendas
            {
                Carros = (int)cbCarro.SelectedValue,
                Quantidade = (int)nmQuant.Value,
                Valor = valor
            };

            this.Close();

        }

        private void FrmAddVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);
        }
    }
}
