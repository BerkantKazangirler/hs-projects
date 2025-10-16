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
    public partial class anagiris : Form
    {
        public anagiris()
        {
            InitializeComponent();
        }
        public string kullaniciadi;
        public string film1;
        public string film2;
        public string film3;
        public string kullaniciadiyedek;
        public int satılanbilet1;
        public int satılanbilet2;
        int orenci;
        int tam;
        private void anagiris_Load(object sender, EventArgs e)
        {
            label1.Text = kullaniciadi;
            label6.Text = satılanbilet1.ToString();
            label7.Text = satılanbilet2.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(kullaniciadi + " Çıkış Yapılsınmı?", "Sinema Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show(kullaniciadi + " Çıkış Yapıldı Giriş Bölümüne Giriliyor");
                Form1 giriş = new Form1();
                giriş.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filmekle film = new filmekle();
            film.kullaniciadiyedek = kullaniciadi;
            film.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filmmenu fmenu = new filmmenu();
            fmenu.film1 = film1;
            fmenu.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            //if (groupBox1.Visible == false)
            {
                groupBox1.Visible = true;
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Fiyatlar Boş");
            }
            else
            {
                orenci = int.Parse(textBox1.Text);
                tam = int.Parse(textBox2.Text);
                MessageBox.Show("Fiyatlar Ayarlandı Öğrenci :" + orenci + " Tam " + tam);
                groupBox1.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sat satıs = new sat();
            satıs.tambilet = tam;
            satıs.orenci = orenci;
            satıs.kullaniciadiyedek = kullaniciadi;
            satıs.Show();
            this.Hide();
        }
    }
}
