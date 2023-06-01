namespace TP6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            double gb, mb, cd;

            gb = double.Parse(caja1.Text);

            mb = gb * 1024;
            cd = mb / 700;

            Cd.Text = cd.ToString();

            caja1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void caja1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cd_Click(object sender, EventArgs e)
        {

        }
    }
}