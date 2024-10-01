using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmCentimetrosPolegadas : Form
    {
        public FrmCentimetrosPolegadas()
        {
            InitializeComponent();
        }

        private void FrmCentimetrosPolegadas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            double centimetros = Convert.ToDouble(txtCentimetros.Text);

            double resultado = centimetros / 2.54;

            txtPolegadas.Text = resultado.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCentimetros.Clear();
            txtPolegadas.Clear();
        }
    }
}
