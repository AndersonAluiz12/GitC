﻿using System;
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
    public partial class frmEditUSuarios : Form
    {
        public frmEditUSuarios()
        {
            InitializeComponent();
        }

        public MVCProject.SistemaBibliotecaDBDataSet.UsuariosRow UsuariosRow;

        private void FrmEditUSuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDBDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.Fill(this.sistemaBibliotecaDBDataSet.Usuarios);

            txtLogin.Text = UsuariosRow.Login;
            txtSenha.Text = UsuariosRow.Senha;
            txtEmail.Text = UsuariosRow.Email;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            UsuariosRow.Login = txtLogin.Text;
            UsuariosRow.Senha = txtSenha.Text;
            UsuariosRow.Email = txtEmail.Text;
        }
    }
}
