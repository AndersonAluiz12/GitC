﻿using DataGridViewExample.Adicao;
using DataGridViewExample.Edicao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
            as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoVendas editVenda = new frmEdicaoVendas();
                        editVenda.VendasRow = vendasSelect;
                        editVenda.ShowDialog();

                        this.vendasTableAdapter.Update(editVenda.VendasRow);
                    }
                    break;
            }
            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddVendas frmVendas = new frmAddVendas();
            frmVendas.ShowDialog();
            
            if(frmVendas.VendasRow?.Carros > 0 && frmVendas.VendasRow?.Valor > 0)

            this.vendasTableAdapter.Insert
                (
                frmVendas.VendasRow.Carros,
                frmVendas.VendasRow.Quantidade,
                frmVendas.VendasRow.Valor,
                frmVendas.VendasRow.Ativo,
                1,
                1,
                frmVendas.VendasRow.DatInc,
                frmVendas.VendasRow.DatAlt
                );
        }
    }
}