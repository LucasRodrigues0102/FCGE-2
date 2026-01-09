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
    public partial class frmAdicionarItem : Form
    {
        private Estoque estoque;
        private Saldo saldo;
        public frmAdicionarItem(Estoque estoque, Saldo saldo)
        {
            InitializeComponent();

            this.estoque = estoque;
            this.saldo = saldo;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                int quantidade = int.Parse(txtQtd.Text);
                double preco = double.Parse(txtValor.Text);
                double custo = double.Parse(txtCusto.Text);

                Item item = new Item();
                item.setDados(nome, quantidade, preco, custo);

                estoque.adicionarItem(item);

                saldo.CustoFabSaldo(quantidade, custo);

                txtNome.Text = "";
                txtValor.Text = "";
                txtQtd.Text = "";
                txtCusto.Text = "";
                MessageBox.Show("Item adicionado com sucesso ao estoque!");
            }

            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }

            catch (FormatException)
            {
                MessageBox.Show("Digite valores numéricos válidos nas caixas de quantidade, valor e custo!!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
