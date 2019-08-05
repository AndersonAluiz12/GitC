using MVCProject.Model;
using MVCProject.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

        }

               
        private void BtLogin_Click(object sender, EventArgs e)
        {
            var result = this.usuariosTableAdapter1.LoginQuery(txtUsu.Text, txtSenha.Text);

            if (result != null)
            {
                Session.User = new Usuario
                {
                    Id = (int)result
                };

                frmPrincipal frm = new frmPrincipal();
                frm.ShowDialog();
            }
            else
            {
                throw new Exception("Testeeee");
            }
        }
    }
}
