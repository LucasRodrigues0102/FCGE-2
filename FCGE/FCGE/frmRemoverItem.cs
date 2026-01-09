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
    public partial class frmRemoverItem : Form
    {
        private Estoque estoque;
        public frmRemoverItem(Estoque estoque)
        {
            InitializeComponent();

            this.estoque = estoque;
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            Item item = estoque.pesquisarItem(nome);

            if (item != null)
            {
                txtNomeEstoque.Text = item.getNome();
                txtQtd.Text = Convert.ToString(item.getQuantidade());
                txtPreco.Text = Convert.ToString(item.getPreco());
            }

            else
            {
                MessageBox.Show("Item não encontrado!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            Item item = estoque.pesquisarItem(nome);

            if(item != null)
            {
                estoque.removerItem(item);

                txtNome.Text = "";
                txtNomeEstoque.Text = "";
                txtPreco.Text = "";
                txtQtd.Text = "";
                MessageBox.Show("Item removido com sucesso!");
            }

            else
            {
                MessageBox.Show("Item não encontrado!");
            }
        }
    }
}
