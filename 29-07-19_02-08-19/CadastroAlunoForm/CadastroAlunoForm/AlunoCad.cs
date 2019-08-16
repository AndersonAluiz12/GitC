using CadastroAlunoForm.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunoForm
{
    public partial class AlunoCad : Form
    {
        public AlunoCad()
        {
            InitializeComponent();
        }

        public Cadastro NovoCadastro = new Cadastro();

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            NovoCadastro.Nome = txAluno.Text;
            NovoCadastro.Idade = (int)nrIdade.Value;

            this.Close();
        }
    }
}
