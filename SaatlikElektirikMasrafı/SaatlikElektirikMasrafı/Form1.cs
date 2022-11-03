using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaatlikElektirikMasrafı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            textBox2.Enabled=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double w, zaman,işlem, sonuç,işlem2,dönüştürme;
            w = Convert.ToDouble(textBox1.Text);
            zaman = Convert.ToDouble(textBox2.Text);
            işlem2 = (w / 1000);
            işlem = ((işlem2/60)*zaman);
            sonuç = (işlem * 2.6);
            label2.Text = (sonuç.ToString());




        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
