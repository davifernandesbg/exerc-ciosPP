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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void tsmMedia_Click(object sender, EventArgs e)
        {
            frmMedia Media = new frmMedia();
            Media.Show();
            this.Hide();
        }

        private void tsmCircunferencia_Click(object sender, EventArgs e)
        {
            frmCircunferencia Circunferencia = new frmCircunferencia();
            Circunferencia.Show();
            this.Hide();
        }

        private void tsmConversao_Click(object sender, EventArgs e)
        {
            frmConversao Conversao = new frmConversao();
            Conversao.Show();
            this.Hide();
        }

        private void médiaPonderadaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMedia Media = new frmMedia();
            Media.Show();
            this.Hide();
        }

        private void circunferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCircunferencia Circunferencia = new frmCircunferencia();
            Circunferencia.Show();
            this.Hide();
        }

        private void conversãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConversao Conversao = new frmConversao();
            Conversao.Show();
            this.Hide();
        }

        private void áreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea Area = new frmArea();
            Area.Show();
            this.Hide();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPecas Pecas = new frmPecas();
            Pecas.Show();
            this.Hide();
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstoque Estoque = new frmEstoque();
            Estoque.Show();
            this.Hide();
        }

        private void dolarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDolar Dolar = new frmDolar();
            Dolar.Show();
            this.Hide();
        }

        private void quadradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuadrado Quadrado = new frmQuadrado();
            Quadrado.Show();
            this.Hide();
        }

        private void comissãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmComissao Comissao = new frmComissao();
            Comissao.Show();
            this.Hide();
        }

        private void energiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEnergia Energia = new frmEnergia();
            Energia.Show();
            this.Hide();
        }
    }
}
