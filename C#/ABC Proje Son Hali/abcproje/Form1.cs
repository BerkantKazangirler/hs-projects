using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace abcproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string kullaniciadi;
        int sifre;
        int token;

        private void label2_Click(object sender, EventArgs e)
        {
            if(groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            try
            {
                kullaniciadi = textBox4.Text;
                sifre = Convert.ToInt32(textBox3.Text);

                if (textBox4.Text == "" || textBox3.Text == "")
                {
                    SoundPlayer hata = new SoundPlayer();
                    string hatakonum = Application.StartupPath + "\\hata.wav";
                    hata.SoundLocation = hatakonum;
                    hata.Play();
                    MessageBox.Show("Girdiğiniz Kullanıcı Adında Boşluk Mevcut.", "ABC SİNEMA - KAYIT", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Kayıt Başarılı.", "ABC SİNEMA - KAYIT", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    token++;
                }
            }
            catch
            {
                SoundPlayer hata = new SoundPlayer();
                string hatakonum = Application.StartupPath + "\\hata.wav";
                hata.SoundLocation = hatakonum;
                hata.Play();
                MessageBox.Show("KOD BÖLÜMÜNDE HATA OLUŞUYOR GİRİŞ YAPTIĞINIZ YÖNTEMİ KONTROL EDİN!", "ABC SİNEMA - PORTAL", MessageBoxButtons.OK);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciaddeneme = textBox1.Text;
                int şifredeneme = int.Parse(textBox2.Text);

                if (kullaniciadi == kullaniciaddeneme && sifre == şifredeneme)
                {
                    if(token >= 1)
                    {
                        MessageBox.Show("Giriş Başarılı.", "ABC SİNEMA - GİRİS", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        a menü = new a();
                        menü.ad = kullaniciadi;
                        menü.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kayıt Olmamışsınız.", "ABC SİNEMA - GİRİS", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
                else
                {
                    MessageBox.Show("Hatalı Giriş.", "ABC SİNEMA - GİRİS", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch
            {
                MessageBox.Show("KOD BÖLÜMÜNDE HATA OLUŞUYOR GİRİŞ YAPTIĞINIZ YÖNTEMİ KONTROL EDİN!", "ABC SİNEMA - PORTAL", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
