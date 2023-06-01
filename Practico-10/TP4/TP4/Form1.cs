namespace TP4
{
    public partial class Aguilera : Form
    {
        public Aguilera()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enviar_Click(object sender, EventArgs e)
        {
            char letra;

            letra = char.Parse(caja1.Text);

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Vocal.Text = "Es Vocal";
            }
            else { Vocal.Text = "No es Vocal"; }

            caja1.Text = "";
        }
    }
}