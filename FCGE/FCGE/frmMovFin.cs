using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCGE
{
    public partial class frmMovFin : Form
    {
        private Saldo saldo;
        public frmMovFin(Saldo saldo)
        {
            InitializeComponent();

            this.saldo = saldo;

            rbAdicionar.Checked = true;
            txtAtual.Text = Convert.ToString(saldo.GetSaldo());
        }

        private void btnEfetuar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAdicionar.Checked == true)
                {
                    double soma = double.Parse(txtTransacao.Text);
                    saldo.AdicionarSaldo(soma);
                    txtAtual.Text = Convert.ToString(saldo.GetSaldo());
                }

                else
                {
                    double subtracao = double.Parse(txtTransacao.Text);
                    saldo.SubtrairSaldo(subtracao);
                    txtAtual.Text = Convert.ToString(saldo.GetSaldo());
                }
            }

            catch (ArgumentException erro)
            {
                MessageBox.Show(erro.Message);
            }

            catch (FormatException)
            {
                MessageBox.Show("Digite um valor numérico na casa da transação!");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
