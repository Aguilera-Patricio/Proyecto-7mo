namespace TP3
{
    public partial class Aguilera : Form
    {
        public Aguilera()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado1, resultado2;

            num1 = double.Parse(caja1.Text);
            num2 = double.Parse(caja2.Text);

            resultado1 = (num1 + num2) * (num1 - num2);
            resultado2 = (num1 * num1) - (num2 * num2);

            result1.Text = resultado1.ToString();
            result2.Text = resultado2.ToString();

            caja1.Text = "";
            caja2.Text = "";
        }
    }
}