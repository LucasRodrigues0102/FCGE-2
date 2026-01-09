using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCGE
{
    public partial class frmNovoLogin : Form
    {
        private Login login;
        public frmNovoLogin(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            string nome = txtLogin.Text;
            string senha = txtSenha.Text;

            if (senha == txtConfirmar.Text)
            {
                User user = new User();
                user.setNome(nome);
                user.setSenha(senha);
                login.adicionarUser(user);
                MessageBox.Show("Novo login criado com sucesso!");
            }

            else
            {
                MessageBox.Show("Diferença entre as senhas inseridas, tente novamente!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
