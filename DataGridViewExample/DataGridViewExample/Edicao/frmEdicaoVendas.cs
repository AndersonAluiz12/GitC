﻿using System;
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
    public partial class frmEdicaoVendas : Form
    {
        public frmEdicaoVendas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow VendasRow;

        private void FrmEdicaoVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

            cbCarro.SelectedValue = VendasRow.Carro;
            txtQuant.Text = VendasRow.Quantidade.ToString();
            txtValue.Text = VendasRow.Valor.ToString();

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            VendasRow.Carro = (int)cbCarro.SelectedValue;
            VendasRow.Quantidade = int.Parse(txtQuant.Text);
            VendasRow.Valor = decimal.Parse(txtValue.Text);

            this.Close();
        }
    }
}
