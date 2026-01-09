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
    public partial class formLogin : System.Windows.Forms.Form
    {
        private Login login;
        public formLogin(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtLogin.Text;
            string senha = txtSenha.Text;

            User user = login.pesquisarUser(nome, senha);

            if (user != null)
            {
                formMenu Menu = new formMenu();
                Menu.Show();
                this.Hide();
                Menu.Closed += (s, args) => this.Close();
            }

            else
            {
                MessageBox.Show("Login ou senha inválidos!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNovoLogin login = new frmNovoLogin(this.login);
            login.ShowDialog();
        }
    }
}
