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
    public partial class frmCircunferencia : Form
    {
        public frmCircunferencia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Raio = Convert.ToDouble(txtRaio.Text);
            double Comprimento = (2 * 3.14 * Raio);

            txtComprimento.Text = Comprimento.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtComprimento.Clear();
            txtRaio.Clear();
            txtComprimento.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
