namespace TP5
{
    public partial class Form1 : Form
    {
        private int h = 0, m = 0, s = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            etLabel.Text = h + " : " + m + " : " + s;

            s = s + 1;

            if (s == 60)
            {
                m = m + 1;

                s = 0;

                if (m == 60)
                {
                    h = h + 1;

                    m = 0;

                    if (h == 24)
                    {
                        h = 0;
                        m = 0;
                        s = 0;

                        etLabel.Text = h + " : " + m + " : " + s;
                    }
                }
            }

        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void etLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            h = 0;
            m = 0;
            s = 0;

            etLabel.Text = h + " : " + m + " : " + s;
        }

        private void etLabel_Click_1(object sender, EventArgs e)
        {

        }

    }
}