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

namespace abcproje
{
    public partial class kayıt : Form
    {
        public kayıt()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=sinema;Uid=root;Pwd='123456'");
        MySqlCommand komut;
        MySqlDataAdapter veriler;
        DataTable tbl;

        int giris = 0;
        string kullanıcıadı;
        string sifre;
        string ssifre;

        public void DataGetir(string sorgu)
        {
            tbl = new DataTable();
            baglanti.Open();
            veriler = new MySqlDataAdapter(sorgu, baglanti);
            baglanti.Close();
        }

        public void KayıtOl()
        {
            string sorgu = "Insert into kayıt (kayıt_ad,kayıt_sifre) values (@kayıt_ad,@kayıt_sifre)";
            komut = new MySqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@kayıt_ad", textBox1.Text);
            komut.Parameters.AddWithValue("@kayıt_sifre", textBox2.Text);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi");
            DataGetir("Select * From sinema");
            Temizle();
        }

        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pastebinp.com/we3eCp7fjPHL2CfJu92w#egsQgdR98WtheaUSSqnfRcQAwe5C5VSj8_IrVLGz9a8=");
            giris++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (giris == 1 && radioButton1.Checked == true)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Gerekli Yerleri Girmediniz");
                }
                else
                {
                    KayıtOl();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı Sözleşmesini Kabul Etmediniz/Girmediniz", "Kayıt Sistemi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void kayıt_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * from sinema";
            DataGetir(sorgu);
            kullanıcıadı = textBox1.Text;
            sifre = textBox2.Text;
            ssifre = textBox3.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
