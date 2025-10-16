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
    public partial class masa : Form
    {
        public masa()
        {
            InitializeComponent();
        }
        string masalar = "";

        private void button1_Click(object sender, EventArgs e)
        {
            işlemler menü = new işlemler();
            menü.Show();
            this.Hide();
        }

        private void masa_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Green;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 1";

            DialogResult dialogResult = MessageBox.Show(masalar+". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Green;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 2";

            DialogResult dialogResult = MessageBox.Show(masalar + ". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Green;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 4";

            DialogResult dialogResult = MessageBox.Show(masalar + ". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Green;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 3";

            DialogResult dialogResult = MessageBox.Show(masalar + ". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Green;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 6";

            DialogResult dialogResult = MessageBox.Show(masalar + ".Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Green;
            masalar = "Masa 5";

            DialogResult dialogResult = MessageBox.Show(masalar + ". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Green;
            masa7.ForeColor = Color.Black;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 8";

            DialogResult dialogResult = MessageBox.Show(masalar + ". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            masa2.ForeColor = Color.Black;
            masa3.ForeColor = Color.Black;
            masa1.ForeColor = Color.Black;
            masa4.ForeColor = Color.Black;
            masa8.ForeColor = Color.Black;
            masa7.ForeColor = Color.Green;
            masa6.ForeColor = Color.Black;
            masa5.ForeColor = Color.Black;
            masalar = "Masa 7";

            DialogResult dialogResult = MessageBox.Show(masalar + ". Masa Seçilsinmi", "Masa Giriş Sistemi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                işlemler frm = new işlemler();
                frm.masa = masalar;
                frm.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show(masalar + " Seçilmedi");
            }
        }
    }
}
