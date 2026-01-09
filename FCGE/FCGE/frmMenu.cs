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
    public partial class formMenu : System.Windows.Forms.Form
    {
        Estoque estoque = new Estoque();
        Saldo saldo = new Saldo();
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdicionarItem add = new frmAdicionarItem(estoque, saldo);
            add.ShowDialog();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            frmRemoverItem remover = new frmRemoverItem(estoque);
            remover.ShowDialog();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            frmExibir exibir = new frmExibir();
            exibir.ShowDialog();
        }

        private void btnMovFin_Click(object sender, EventArgs e)
        {
            frmMovFin movfin = new frmMovFin(saldo);
            movfin.ShowDialog();
        }

        private void btnHist_Click(object sender, EventArgs e)
        {
            frmHist hist = new frmHist();
            hist.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
