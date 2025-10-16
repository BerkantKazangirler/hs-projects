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
    public partial class filmekle : Form
    {
        public filmekle()
        {
            InitializeComponent();
        }

        public string kadıyedek;
        public int tambilet;
        public int orencibilet;

        string salon1;

        string salon2;

        string salon3;

        private void button4_Click(object sender, EventArgs e)
        {
            salon1 = textBox1.Text;

            if(salon1 == "")
            {
                MessageBox.Show("SİNEMA İSMİ GİRMEDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                button1.ForeColor = Color.Green;
                label6.Text = "FILM ADI " + salon1; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a ana = new a();
            ana.salon1 = salon1;
            ana.salon2 = salon2;
            ana.salon3 = salon3;
            ana.tam = tambilet;
            ana.orenci = orencibilet;

            if (salon1 == "")
            {
                salon1 = "GİRİLMEDİ";
            }

            if (salon2 == "")
            {
                salon2 = "GİRİLMEDİ";
            }

            if (salon3 == "")
            {
                salon3 = "GİRİLMEDİ";
            }

            ana.ad = kadıyedek;
            ana.Show();
            this.Hide();
        }

        private void filmekle_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            salon2 = textBox2.Text;

            if (salon2 == "")
            {
                MessageBox.Show("SİNEMA İSMİ GİRMEDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                button2.ForeColor = Color.Green;
                label7.Text = "FILM ADI " + salon2;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("BOŞ FİLM'İ SİLEMEZSİN");
            }
            else
            {
                salon1 = "";
                button1.ForeColor = Color.Brown;
                label6.Text = "FILM";
                textBox1.Text = "";
                MessageBox.Show("KAYITLI FİLM SİLİNDİ");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(textBox2.Text == "")
            {
                MessageBox.Show("BOŞ FİLM'İ SİLEMEZSİN");
            }
            else
            {
                salon2 = "";
                button2.ForeColor = Color.Brown;
                label7.Text = "FILM";
                textBox2.Text = "";
                MessageBox.Show("KAYITLI FİLM SİLİNDİ");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("BOŞ FİLM'İ SİLEMEZSİN");
            }
            else
            {
                salon3 = "";
                button3.ForeColor = Color.Brown;
                label8.Text = "FILM";
                textBox3.Text = "";
                MessageBox.Show("KAYITLI FİLM SİLİNDİ");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            salon3 = textBox3.Text;

            if (salon3 == "")
            {
                MessageBox.Show("SİNEMA İSMİ GİRMEDİNİZ", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                button3.ForeColor = Color.Green;
                label8.Text = "FILM ADI " + salon3;
            }
        }
    }
}
