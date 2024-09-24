namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                Jogo formularioJogo = new Jogo();
                formularioJogo.ShowDialog();
            }

            else 
            {
                progressBar1.Value = progressBar1.Value + 20;
            }
            
        }

    }
}
