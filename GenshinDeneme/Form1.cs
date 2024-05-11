namespace GenshinDeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button2.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac == 3)
            {

                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                button2.Visible = true;
                timer1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible=false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            button2.Visible = false;
            sayac = 0;
        }
    }
}
