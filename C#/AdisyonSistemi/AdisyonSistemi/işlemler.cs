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
    public partial class işlemler : Form
    {
        public işlemler()
        {
            InitializeComponent();
        }
        public string kullanıcıs, kullanıcıad;
        public string masa;

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void isimlabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ödeme öde = new ödeme();
            öde.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            masa masa = new masa();
            masa.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            menü menü = new menü();
            menü.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(masa);
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(kullanıcıad + " Çıkmaya Emin Misin?", "Sistem Kapanma", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
               
            }
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void menü_Load(object sender, EventArgs e)
        {
            isimlabel.Text = kullanıcıad;
            tarihsaat.Start();
        }
    }
}
