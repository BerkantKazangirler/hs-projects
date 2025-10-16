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

namespace abcpersonelsirket
{
    public partial class istatislik : Form
    {
        public istatislik()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        private void istatislik_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "sirketdb";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
        }

        public void ESG(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        public DataTable Listele(string sorgu)
        {
            DataTable tbl = new DataTable();
            baglanti.Open();
            MySqlDataAdapter veriler = new MySqlDataAdapter(sorgu, baglanti);
            veriler.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele("select COUNT(*) AS 'Erkek Personel Sayısı' from personel where cinsiyet = 'Erkek'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Listele("select COUNT(*) AS 'Kadın Personel Sayısı' from personel where cinsiyet = 'Kadın'");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listele("select COUNT(*) from personel");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Listele("select * from personel order by dogum_tarihi desc limit 3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Listele("select * from personel order by maas desc limit 3");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Listele("select * from personel order by maas limit 3");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Listele("select * from personel order by ise_baslama_tarihi limit 3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Listele("select * from personel order by dogum_tarihi limit 3");
        }
    }
}
