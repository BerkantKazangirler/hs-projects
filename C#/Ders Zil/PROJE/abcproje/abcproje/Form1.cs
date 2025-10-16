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
using MySql.Data.MySqlClient;

namespace abcproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinema;Uid=root;Pwd='123456'");
        MySqlCommand komut;
        MySqlDataAdapter veriler;
        DataTable tbl;

        public string kullaniciadi;
        string aranankullanıcıadı;
        int aranansifre;
        string sifre;
        int token;

        public void DataGetir(string sorgu)
        {
            tbl = new DataTable();
            baglanti.Open();
            veriler = new MySqlDataAdapter(sorgu, baglanti);
            baglanti.Close();
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("bla");
            }
            else
            {
                kullaniciadi = textBox1.Text;
                sifre = textBox2.Text;
                DataGetir("select * from kayıt where marka LIKE '" + kullaniciadi + "%'");
                if (kullaniciadi == aranankullanıcıadı)
                {
                    MessageBox.Show("A");
                }
            }
        }
    }
}
