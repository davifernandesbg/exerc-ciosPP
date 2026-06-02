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
    public partial class frmComissao : Form
    {
        public frmComissao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            int ID = Convert.ToInt32(txtID.Text);
            int Codigo = Convert.ToInt32(txtCodigo.Text);
            int Quantidade = Convert.ToInt32(txtQuantidade.Text);
            double Preco = Convert.ToDouble(txtPreco.Text);

            double Total = Preco * Quantidade;
            double Comissao = Total * 0.05;

            txtResultado.Text =
                        $"ID do vendedor: {ID}\r\n" +
                        $"Código da peça: {Codigo}\r\n" +
                        $"Preço Unitário: R$ {Preco}\r\n" +
                        $"Quantidade Vendida: {Quantidade}\r\n" +
                        $"Total da Venda: R$ {Total}\r\n" +
                        $"Comissão do Vendedor: R$ {Comissao}";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtCodigo.Clear();
            txtQuantidade.Clear();
            txtPreco.Clear();
            txtResultado.Clear();
            txtID.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
