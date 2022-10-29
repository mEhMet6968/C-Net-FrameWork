using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int a,b;
            a= Convert.ToInt32(textBox1.Text);
            b= Convert.ToInt32(textBox2.Text);
            double kuvvet;
            for (int i = 0; i < b; i++)
            {
                kuvvet = Math.Pow(a, i);
                listBox1.Items.Add(kuvvet);
            }
        }


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Clear();
        }
    }
}
