using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=araba_db;Uid=root;Pwd='123456'");
        MySqlCommand komut;
        MySqlDataAdapter veriler;
        DataTable tbl;

        public DataTable Listele(string sorgu)
        {
            tbl = new DataTable();
            baglanti.Open();
            veriler = new MySqlDataAdapter(sorgu, baglanti);
            veriler.Fill(tbl);
            baglanti.Close();
            return tbl;
        }

        public void Çık()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "ABC Emlak", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(groupBox3.Visible == true)
            {
                groupBox3.Visible = false;
            }
            else
            {
                groupBox3.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            evler ev = new evler();
            ev.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Çık();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/abc-emlak-test/ana-sayfa");
        }
    }
}
