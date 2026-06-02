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
    public partial class frmConversao : Form
    {
        public frmConversao()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Fahrenheit = Convert.ToDouble(txtFahrenheit.Text);
            double Celsius = Math.Round(5 * (Fahrenheit - 32) / 9);

            txtCelsius.Text = Celsius.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCelsius.Clear();
            txtFahrenheit.Clear();
            txtCelsius.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmMenu Menu = new frmMenu();
            Menu.Show();
            this.Close();
        }
    }
}
