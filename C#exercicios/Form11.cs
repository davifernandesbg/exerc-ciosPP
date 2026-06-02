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
    public partial class frmEnergia : Form
    {
        public frmEnergia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Quantidade = Convert.ToDouble(txtQuantidade.Text);
            double Preco = Convert.ToDouble(txtPreco.Text);

            double Valor = Quantidade * Preco;

            txtValor.Text = Valor.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPreco.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtPreco.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
