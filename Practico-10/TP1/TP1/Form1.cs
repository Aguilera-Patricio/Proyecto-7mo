namespace TP1
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

        private void Enviar_Click(object sender, EventArgs e)
        {
            string nombre;

            nombre = caja.Text;

            label2.Text = "Ahora estás en la Matrix " + nombre;

            caja.Text = "";
        }

        private void caja_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}