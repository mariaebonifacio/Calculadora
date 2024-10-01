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
    public partial class Jogo : Form
    {
        float valor1 = 0;
        string operacao = "";

        public Jogo()
        {
            InitializeComponent();
        }

        private void nmr1_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "1";
        }

        private void nmr2_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "2";
        }

        private void nmr3_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "3";
        }

        private void nmr4_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "4";
        }

        private void nmr5_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "5";
        }

        private void nmr6_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "6";
        }

        private void nmr7_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "7";
        }

        private void nmr8_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "8";
        }

        private void nmr9_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "9";
        }

        private void nmr0_Click(object sender, EventArgs e)
        {
            Visor.Text = Visor.Text + "0";
        }

        private void buttonDeMais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "adicao";
            Visor.Text = "";
        }
        private void buttonMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "subtracao";
            Visor.Text = "";
        }



        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "multiplicacao";
            Visor.Text = "";
        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(Visor.Text);
            operacao = "divisao";
            Visor.Text = "";
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (this.operacao == "adicao")
            {
                float resultado = valor1 + Convert.ToSingle(Visor.Text);
                Visor.Text = resultado.ToString();
            }

            if (this.operacao == "subtracao")
            {
                float resultado = valor1 - Convert.ToSingle(Visor.Text);
                Visor.Text = resultado.ToString();
            }

            if (this.operacao == "multiplicacao")
            {
                float resultado = valor1 * Convert.ToSingle(Visor.Text);
                Visor.Text = resultado.ToString();
            }

            if (this.operacao == "divisao")
            {
                float resultado = valor1 / Convert.ToSingle(Visor.Text);
                Visor.Text = resultado.ToString();
            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Visor.Clear();

        }

        private void buttonOff_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Jogo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void celsiusParaFahrenheitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConversor formularioConversor = new frmConversor();
            formularioConversor.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
