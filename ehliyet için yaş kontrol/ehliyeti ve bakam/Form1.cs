using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ehliyeti_ve_bakam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int yas, sayi, sayi2;
            sayi = Convert.ToInt32(textBox1.Text);

            if (sayi > 18) 
            {
                MessageBox.Show("Bence ehliyet alabilirsin geç bile kaldın zaten","Uyarı");
            }


            else if (sayi <= 17)
            {
                MessageBox.Show("Büyüde gel", "Malesef");
            }





        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
    }
}
