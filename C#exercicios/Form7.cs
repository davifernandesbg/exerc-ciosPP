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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Minimo = Convert.ToDouble(txtMin.Text);
            double Maximo = Convert.ToDouble(txtMax.Text);

            double EstoqueMedio = (Minimo + Maximo) / 2;

            txtMedia.Text = EstoqueMedio.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMax.Clear();
            txtMin.Clear();
            txtMedia.Clear();
            txtMin.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
