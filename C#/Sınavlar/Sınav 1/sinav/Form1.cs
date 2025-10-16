using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, hesaplama;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            hesaplama = (sayi1 + sayi2);
            label5.Visible = true;
            label5.Text = hesaplama.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, hesaplama;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            hesaplama = (sayi1 - sayi2);
            label5.Visible = true;
            label5.Text = hesaplama.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, hesaplama;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            hesaplama = (sayi1 / sayi2);
            label5.Visible = true;
            label5.Text = hesaplama.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, hesaplama;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            hesaplama = (sayi1 * sayi2);
            label5.Visible = true;
            label5.Text = hesaplama.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int ortalama;
            ortalama = Convert.ToInt32(textBox4.Text);
            if (ortalama >= 85)
            {
                label7.Visible = true;
                label7.Text = "Takdir Belgesi Almaya Hak Kazandınız";
            }
            if (ortalama >= 70 && ortalama <= 84)
            {
                label7.Visible = true;
                label7.Text = "Teşekkür belgesi almaya hak kazandınız";
            }
            if (ortalama < 69)
            {
                label7.Visible = true;
               label7.Text = "Belge Alamadınız";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int faktoriel;
            faktoriel = Convert.ToInt32(textBox3.Text);
            if(faktoriel == 0)
            {
                label10.Visible = true;
                label10.Text = "1";
            }
        }
    }
}
