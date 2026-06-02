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
    public partial class frmPecas : Form
    {
        public frmPecas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Codigo = Convert.ToInt32(txtCodigo.Text);
            double Valor = Convert.ToDouble(txtValorP.Text);
            int Quantidade = Convert.ToInt32(txtQuantidade.Text);

            double ValorTotal = Quantidade * Valor;
            txtTotal.Text = $"O valor total de vendas da peça de código: {Codigo} é R$ {ValorTotal}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtQuantidade.Clear();
            txtValorP.Clear();
            txtTotal.Clear();
            txtCodigo.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
