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
    public partial class frmQuadrado : Form
    {
        public frmQuadrado()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double N1 = Convert.ToDouble(txtN1.Text);
            double N2 = Convert.ToDouble(txtN2.Text);
            double N3 = Convert.ToDouble(txtN3.Text);
            double N4 = Convert.ToDouble(txtN4.Text);

            double Soma = (N1 * N1) + (N2 * N2) + (N3 * N3) + (N4 * N4);

            txtSoma.Text = Soma.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN4.Clear();
            txtSoma.Clear();
            txtN1.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
