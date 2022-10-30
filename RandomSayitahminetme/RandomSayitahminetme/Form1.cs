using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSayitahminetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int sayac = 0;
        private int sayi;


        private void Form1_Load(object sender, EventArgs e)
        {          
            
            label1.Visible = true;
            Random rastgele = new Random();
            sayi = rastgele.Next(1, 51);
       

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            sayac += 1;
            label1.Visible = true;
            int girilenSayi;
            girilenSayi = int.Parse(textBox1.Text);
            if (sayac >= 6)
            {
                MessageBox.Show( "Kaybettiniz","Bir dahakine artık");
            }
            if (sayac < 6)
            {
            if (girilenSayi == sayi)
            {
              label1.Font = new Font("Mehmet", 10, FontStyle.Bold);
              label1.Text = ("TEBRİKLER, bildiniz");
                  
            }
            if (girilenSayi > 50)
            {
             MessageBox.Show("50 den büyük sayı giremezsin", "Fazla büyük");
             label1.Visible = false;
            }
             else if (girilenSayi > sayi && girilenSayi < 50)
              {
               label1.Text = ("Büyük sayı girdiniz, küçük giriniz.");
               listBox1.Items.Add(textBox1.Text);
              }
              else if (girilenSayi < sayi)
               {
                    label1.Text = ("Küçük sayı girdiniz, büyük giriniz.");
                    listBox1.Items.Add(textBox1.Text);
                }
            }



            }


            }




        }

    

