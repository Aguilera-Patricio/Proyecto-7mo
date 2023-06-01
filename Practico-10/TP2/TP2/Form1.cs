namespace TP2
{
    public partial class Aguilera : Form
    {
        public Aguilera()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, div, suma, resta, mult;

            num1 = double.Parse(caja1.Text);
            num2 = double.Parse(caja2.Text);

            suma = num1 + num2;
            resta = num1 - num2;
            div = num1 / num2;
            mult = num1 * num2;

            Suma.Text = suma.ToString();
            Resta.Text = resta.ToString();
            Division.Text = div.ToString();
            Mult.Text = mult.ToString();

        }
    }
}