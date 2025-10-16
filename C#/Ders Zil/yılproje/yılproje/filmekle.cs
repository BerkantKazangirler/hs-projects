using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılproje
{
    public partial class filmekle : Form
    {
        public filmekle()
        {
            InitializeComponent();
        }
        string filmadı;
        public string kullaniciadiyedek;
        int yas;
        string film1;
        string film2;
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox4.Text == "0")
                {
                    MessageBox.Show("Film Adı Yada Yas'ı Boş Girdiniz");
                }
                else
                {
                    filmadı = textBox1.Text;
                    yas = int.Parse(textBox4.Text);
                    button1.Text = "Film Adı :" + filmadı;
                    button1.ForeColor = Color.Green;
                    film1 = filmadı;
                }
            }
            catch
            {
                MessageBox.Show("Kod'ta Hata Var!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Film 2")
            {
                MessageBox.Show("Film 2 Kataloğu Boş Aktif Bir Film Yok");
            }
            else
            {
                MessageBox.Show(button2.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text == "Film 1")
            {
                MessageBox.Show("Film 1 Kataloğu Boş Aktif Bir Film Yok");
            }
            else
            {
                MessageBox.Show(button1.Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "" || textBox5.Text == "0")
                {
                    MessageBox.Show("Film Adı Yada Yas'ı Boş Girdiniz");
                }
                else
                {
                    filmadı = textBox2.Text;
                    yas = int.Parse(textBox5.Text);
                    button2.Text = "Film Adı :" + filmadı;
                    button2.ForeColor = Color.Green;
                    film2 = filmadı;
                }
            }
            catch
            {
                MessageBox.Show("Kod'ta Hata Var!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            anagiris giris = new anagiris();
            giris.Show();
            giris.kullaniciadi = kullaniciadiyedek;
            giris.film1 = film1;
            giris.film2 = film2;
            this.Hide();
        }
    }
}
