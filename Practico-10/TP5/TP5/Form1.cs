namespace TP5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int h = 0, m = 0, s = 0;

            do
            {
                etLabel.Text = h + " : " + m + " : " + s;

                s = s + 1;

                MessageBox.Show(h + " : " + m + " : " + s);

                if (s == 59)
                {
                    m = m + 1;

                    s = 0;

                    if (m == 59)
                    {
                        h = h + 1;

                        m = 0;
                    }
                }

            } while (h < 24);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}