using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaMatik
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int b = 0;
        int o = 0;
        int y = 0;
        int el = 0;
        int i = 0;
        int yü = 0;
        public static int para = 0;

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            b += 1;
            para += 5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = b.ToString();
            label2.Text = o.ToString();
            label3.Text = y.ToString();
            label4.Text = el.ToString();
            label5.Text = yü.ToString();
            label6.Text = i.ToString();
            label8.Text = para.ToString() + " Toplam Yatırdığınız Para";
            label9.Text = Form1.toplambakiye.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            o += 1;
            para += 10;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            y += 1;
            para += 20;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            el += 1;
            para += 50;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            yü += 1;
            para += 100;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            i += 1;
            para += 200;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.toplambakiye -= para;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            para = 0;
            b = 0;
            o = 0;
            y = 0;
            el = 0;
            i = 0;
            yü = 0;
        }
    }
}
