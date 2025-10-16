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
    public partial class menü : Form
    {
        public menü()
        {
            InitializeComponent();
        }
        int adett = 1;
        string yemek;

        private void button7_Click(object sender, EventArgs e)
        {
            yemekler.Visible = true;
            ic.Visible = false;
            tatlı.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
            yemek = "Hamburger";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            adett = Convert.ToInt32(textBox1.Text);
            MessageBox.Show(adett.ToString());
            textBox1.Text = "1";
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {
            adet.Visible = true;
            adett = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yemekler.Visible = false;
            ic.Visible = true;
            tatlı.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yemekler.Visible = false;
            ic.Visible = false;
            tatlı.Visible = true;
        }
    }
}
