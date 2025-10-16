using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcproje
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        public string ad;
        public int tam;
        public int orenci;

        public string salon1;
        public string salon2;
        public string salon3;

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = ad;
            label15.Text = Convert.ToString(orenci);
            label12.Text = Convert.ToString(tam);
            if (salon1 == null)
            {
                label7.Text = "GİRİLMEDİ";
            }
            else
            {
                label7.Text = salon1;
            }
            if (salon2 == null)
            {
                label8.Text = "GİRİLMEDİ";
            }
            else
            {
                label8.Text = salon2;
            }
            if (salon3 == null)
            {
                label9.Text = "GİRİLMEDİ";
            }
            else
            {
                label9.Text = salon3;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            filmekle filmekle = new filmekle();
            filmekle.kadıyedek = ad;
            filmekle.tambilet = tam;
            filmekle.orencibilet = orenci;
            filmekle.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            koltuk koltuk = new koltuk();
            koltuk.kadıyedek = ad;
            koltuk.salon1 = salon1;
            koltuk.salon2 = salon2;
            koltuk.salon3 = salon3;
            koltuk.tam = tam;
            koltuk.orenci = orenci;
            koltuk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(groupBox2.Visible == true)
            {
                groupBox2.Visible = false;
            }
            else
            {
                groupBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tam = Convert.ToInt32(textBox2.Text);
                orenci = Convert.ToInt32(textBox1.Text);
                label15.Text = orenci.ToString();
                label12.Text = tam.ToString();
            }
            catch
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
