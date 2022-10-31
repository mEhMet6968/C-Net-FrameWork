using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31._10._2022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ilk, son;
            ilk = Convert.ToInt32(textBox1.Text);
            son = Convert.ToInt32(textBox2.Text);
            for (int i = ilk; i < son; i++)
            {
                if (i%3==0 && i%5==0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }

        }
    }
}