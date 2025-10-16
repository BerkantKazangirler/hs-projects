using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdisyonSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string kullanıcı_ad;
        string sifre;

        private void button1_Click(object sender, EventArgs e)
        {
            kullanıcı_ad = textBox1.Text;
            sifre = textBox2.Text;
            try
            {
                if (textBox1.Text == "" && textBox2.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Giriş Yapmayınız");
                }
                else
                {
                    MessageBox.Show("Kayıt Başarılı");
                }
            }
            catch
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(kayit.Visible == true)
            {
                kayit.Visible = false;
            }
            else
            {
                kayit.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (giriş.Visible == true)
            {
                giriş.Visible = false;
            }
            else
            {
                giriş.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try // a
            {
                if(textBox4.Text == "" && textBox3.Text == "")
                {
                    MessageBox.Show("Lütfen Boş Giriş Yapmayınız");
                }
                else
                {
                    if(kullanıcı_ad == textBox4.Text && sifre == textBox3.Text)
                    {
                        MessageBox.Show("Lütfen Arayüz Seçiniz");
                        groupBox1.Visible = true;
                        kayit.Visible = false;
                        giriş.Visible = false;
                        label5.Visible = false;
                        button3.Visible = false;
                        label6.Visible = false;
                        button4.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Giriş Hatalı");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Giriş Hatalı");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //işlemler menü = new işlemler();
            //menü.Show();
            //this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show(kullanıcı_ad + " Arayüz Renkli Olsunmu?", "Arayüz Sistemi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Giriş Yapılıyor Merhaba " + textBox4.Text);
                    işlemlerayayüz frm = new işlemlerayayüz();
                    frm.kullanıcıad = textBox4.Text;
                    frm.kullanıcıs = textBox3.Text;
                    frm.Show();
                    this.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {
                    checkBox1.Checked = false;
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show(kullanıcı_ad + " Arayüz Düz Olsunmu?", "Arayüz Sistemi", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    MessageBox.Show("Giriş Yapılıyor Merhaba " + textBox4.Text);
                    işlemler arayüz = new işlemler();
                    arayüz.kullanıcıad = textBox4.Text;
                    arayüz.kullanıcıs = textBox3.Text;
                    arayüz.Show();
                    this.Hide();
                }
                else if (dialogResult == DialogResult.No)
                {
                    checkBox1.Checked = false;
                }
            }
        }
    }
}
