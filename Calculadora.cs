namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                Jogo formularioJogo = new Jogo();
                formularioJogo.ShowDialog();
            }

            progressBar1.Value = progressBar1.Value + 20;
        }
    }
}
