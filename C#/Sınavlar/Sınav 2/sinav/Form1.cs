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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox4.Text);
            int sayi2 = Convert.ToInt32(textBox3.Text);
            int çarp;
            çarp = sayi1 * sayi2;
            textBox1.Text = çarp.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox4.Text);
            int sayi2 = Convert.ToInt32(textBox3.Text);
            int bölme;
            bölme = sayi1 / sayi2;
            textBox2.Text = bölme.ToString();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double vizenot = Convert.ToDouble(vize.Text);
            double finalnot = Convert.ToDouble(final.Text);
            double vizehesap;
            vizehesap = vizenot * 0.6;
            double finalhesap;
            finalhesap = finalnot * 0.4;
            double toplam;
            toplam = (vizehesap + finalhesap);
            label5.Visible = true;
            label6.Visible = true;
            if(toplam < 50)
            {
                label6.Text = "Kaldı";
            }
            else
            {
                label6.Text = "Geçti";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad = textBox6.Text;
            string soyad = textBox7.Text;
            string plaka = textBox5.Text;
            string tam;
            tam = soyad + ad + plaka + comboBox1.Text;
            label7.Visible = true;
            label7.Text = tam.ToString();
         }

        private void button6_Click(object sender, EventArgs e)
        {
            {
                if(textBox12.Text == "")
                {
                    MessageBox.Show("Boş");
                }
                else
                {
                    string ürünad = textBox12.Text;
                    comboBox2.Items.Add(ürünad);
                    MessageBox.Show("Ürün Eklendi");
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(stok.Visible == true)
            {
                stok.Visible = false;
            }
            else
            {
                stok.Visible = true;
            }
            MessageBox.Show("Liste Açıldı");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int miktar = Convert.ToInt32(textBox13.Text);
            int beden = 38;
            if(comboBox2.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Seçiniz");
            }
            else if(textBox13.Text == "")
            {
                MessageBox.Show("Lütfen Miktarı Giriniz");
            }
            if(radioButton1.Checked == true)
            {
                beden = 37;
            }
            if(radioButton2.Checked == true)
            {
                beden = 38;
            }
            if(radioButton3.Checked == true)
            {
                beden = 39;
            }
            else
            {
                listBox1.Items.Add(comboBox2.Text);
                listBox2.Items.Add(miktar);
                listBox3.Items.Add(beden);
                MessageBox.Show("Ürün Eklendi");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            textBox13.Text = "";
            MessageBox.Show("Sıfırlandı");
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        { 
          // Alan = kenar uzunluğunun karesi alınarak bulunur
          // Çevre = karenin çevre uzunluğunun karenin tüm kenarlarının toplamına eşit
            int kareuzun = Convert.ToInt32(textBox8.Text);
            int cevre;
            int alan;
            cevre = (kareuzun / 4);
            alan = kareuzun * kareuzun;
            textBox9.Text = cevre.ToString();
            textBox10.Text = alan.ToString();
        }
    }
}
