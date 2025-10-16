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
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }
        string kullanici_adi;
        int sifre;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Boş Giriş Yapmayınız!");
            }
            else
            {
                kullanici_adi = textBox1.Text;
                sifre = int.Parse(textBox2.Text);
                try
                {
                    DialogResult dialogResult = MessageBox.Show(kullanici_adi + " İsminde Kayıt Olunsunmu?", "Sinema Sistemi", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        MessageBox.Show(kullanici_adi + " Adında Kayıt Olundu Giriş Bölümüne Yönlendiriyorsunuz");
                        Form1 giriş = new Form1();
                        giriş.kullaniciadi = kullanici_adi;
                        giriş.şifre = sifre;
                        giriş.Show();
                        this.Hide();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Kod Bölümünde Hata Mevcut");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(kullanici_adi + " Çıkış Yapılsınmı?", "Sinema Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(kullanici_adi + " Giriş Bölümüe Geçilsinmi?");
                Form1 giriş = new Form1();
                giriş.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
