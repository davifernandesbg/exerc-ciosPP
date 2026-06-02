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
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1 = Convert.ToDouble(txtNota1.Text);
            double Nota2 = Convert.ToDouble(txtNota2.Text);

            double Media = (Nota1 * 6 + Nota2 * 4) / 10;

            txtMedia.Text = Media.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtMedia.Clear();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();

        }
    }
}
