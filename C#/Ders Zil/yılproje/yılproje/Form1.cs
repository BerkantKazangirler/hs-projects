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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string kullaniciadi;
        public int şifre;

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciaddeneme = textBox1.Text;
            int şifredeneme = int.Parse(textBox2.Text);
            if(kullaniciadi == kullaniciaddeneme && şifre == şifredeneme)
            {
                MessageBox.Show("Giriş Başarılı Menüye Yönlendiriyorsunuz");
                anagiris menü = new anagiris();
                menü.kullaniciadi = kullaniciadi;
                menü.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Deneme!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Kayıt Sistemine Giriş Yapılsınmı?", "Sinema Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                kayıt kayıtolma = new kayıt();
                kayıtolma.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anagiris deneme = new anagiris();
            deneme.Show();
        }
    }
}
