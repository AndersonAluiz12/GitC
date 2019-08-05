using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            
            if (Session.User == null)
            {
                throw new Exception("Erro Critico no Sistemsa");
            }
        }

        
        private void UsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsu = new frmUsuarios();
            frmUsu.ShowDialog();
        }

        private void AutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores frmAutor = new frmAutores();
            frmAutor.ShowDialog();
        }

        private void GenêrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGeneros frmGener = new frmGeneros();
            frmGener.ShowDialog();
        }

        private void LivrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivros frmLivros = new frmLivros();
            frmLivros.ShowDialog();
        }

        private void LocaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocacoes frmLoca = new frmLocacoes();
            frmLoca.ShowDialog();
        }

        private void EditorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditoras frmEditora = new frmEditoras();
            frmEditora.ShowDialog();
        }
    }
}
