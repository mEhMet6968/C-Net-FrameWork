namespace BankaMatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int toplambakiye;
        int b = 0;
        int o = 0;
        int y = 0;
        int el = 0;
        int i = 0;
        int yü = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "0";
            label2.Text = "0";
            label3.Text = "0";
            label4.Text = "0";
            label5.Text = "0";
            timer1.Start();
            label6.Text = "0";
            trackBar1.Maximum = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplambakiye += trackBar1.Value;

            if (trackBar1.Value >= 200)
            {
                int count = trackBar1.Value / 200;
                i += count;
                trackBar1.Value = trackBar1.Value % 200;

            }
            if (trackBar1.Value >= 100)
            {
                int count = trackBar1.Value / 100;
                yü += count;
                trackBar1.Value = trackBar1.Value % 100;
            }
            if (trackBar1.Value >= 50)
            {
                int count = trackBar1.Value / 50;
                el += count;
                trackBar1.Value = trackBar1.Value % 50;
            }
            if (trackBar1.Value >= 20)
            {
                int count = trackBar1.Value / 20;
                y += count;
                trackBar1.Value = trackBar1.Value % 20;
            }
            if (trackBar1.Value >= 10)
            {
                int count = trackBar1.Value / 10;
                o += count;
                trackBar1.Value = trackBar1.Value % 10;
            }
            if (trackBar1.Value >= 5)
            {
                int count = trackBar1.Value / 5;
                b += count;
                trackBar1.Value = trackBar1.Value % 5;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label9.Text = trackBar1.Value.ToString();
            label1.Text = b.ToString();
            label2.Text = o.ToString();
            label3.Text = y.ToString();
            label4.Text = el.ToString();
            label5.Text = yü.ToString();
            label6.Text = i.ToString();
            label10.Text = Form1.toplambakiye.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();
        }
    }
}