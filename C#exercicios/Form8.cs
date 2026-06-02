using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_exercicios
{
    public partial class frmDolar : Form
    {
        public frmDolar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Cotacao = Convert.ToDouble(txtCotacao.Text);
            double Dolar = Convert.ToDouble(txtDolar.Text);

            double Real = (Dolar * Cotacao);

            txtReal.Text = Real.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCotacao.Clear();
            txtDolar.Clear();
            txtReal.Clear();
            txtCotacao.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Close();
        }
    }
}
