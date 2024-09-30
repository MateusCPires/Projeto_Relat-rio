using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Relatório.Formulários
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        int Erros = 0;

        private bool CaixasOK()
        {
            if (txtNomeUsuario.Text == "")
            {
                errErro.SetError(txtNomeUsuario, "Informar usuário");
                return false;
            }
            else
            {
                errErro.SetError(txtNomeUsuario, "");
            }
            if (txtSenha.Text == "")
            {
                errErro.SetError(txtSenha, "Informar senha");
                return false;
            }
            else
            {
                errErro.SetError(txtSenha, "");
            }
            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CaixasOK())
            {
                if(txtNomeUsuario.Text!="Eu" && txtSenha.Text != "123")
                {
                    MessageBox.Show("Usuário ou senha inválidos");
                    Erros++;
                    if (Erros == 3)
                    {
                        MessageBox.Show("Número máximo de tentativas gasto");
                        this.Close();
                    }
                }
            }
            else
            {
                Properties.Settings.Default.NivelUsuarioLogado = 1;
                Properties.Settings.Default.NomeUsuarioLogado = txtNomeUsuario.Text;
                frmMenu objMenu = new frmMenu();
                objMenu.Show();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
