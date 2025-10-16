using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            int hesapla;
            hesapla = (sayi1 + sayi2);
            soru1yazdırma.Visible = true;
            soru1yazdırma.Text = ("Sonuç :"+hesapla.ToString());
        }

        private void soru1yazdırma_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int yazili1 = Convert.ToInt32(textBox3.Text);
            int yazili2 = Convert.ToInt32(textBox4.Text);
            int sözlü = Convert.ToInt32(textBox5.Text);
            int ortalama;
            ortalama = (yazili1 + yazili2 + sözlü) / 3;
            soru3ortalama.Visible = true;
            soru3ortalama.Text = ("Ortalama : " + ortalama);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string metin1 = textBox6.Text;
            string metin2 = textBox7.Text;
            
            soru4yazdır.Visible = true;
            soru4yazdır.Text = metin1+" "+metin2;
        }

        private void soru2kırmızı_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void soru2mavi_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void soru2turuncu_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Orange;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double uzun = Convert.ToDouble(textBox9.Text);
            double kisa = Convert.ToDouble(textBox8.Text);
            double hesapla;
            if(radioButton1.Checked)
            {
                label8.Visible = true;
                hesapla = (uzun * uzun);
                label8.Text = ("Alanı " + hesapla);
            }
            if(radioButton2.Checked)
            {
                label8.Visible = true;
                hesapla = (uzun * 2) + (kisa * 2);
                label8.Text = ("Çevresi " + hesapla);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox10.Text);
            int sayi2 = Convert.ToInt32(textBox11.Text);
            int hesapla;
            hesapla = sayi1 + sayi2;
            if (hesapla % 2==0)
            {
                listBox2.Items.Add(hesapla);
            }
            if (hesapla % 2 == 1)
            {
              listBox1.Items.Add(hesapla);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void soru2kırmızı_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
