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
    public partial class personel_ekle : Form
    {
        public personel_ekle()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

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


        private void personel_ekle_Load(object sender, EventArgs e)
        {
            build.Server = "Localhost";
            build.UserID = "root";
            build.Database = "sirketdb";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(ad.Text == "" && soyad.Text == "" && departman.Text == "" && cin.Text == "" && rütbe.Text == "" && maas.Text == "" && posta.Text == "")
            {
                MessageBox.Show("Boşluk Mevcut");
            }
            else
            {
                ESG("insert into personel(personel_adi, personel_soyadi, departman, unvan, maas, dogum_tarihi, ise_baslama_tarihi, eposta, cinsiyet) values('" + ad.Text + "', '" + soyad.Text + "','" + departman.SelectedItem + "','" + rütbe.SelectedItem + "','" + maas.Text + "','" + dtarih.Value.ToString("yyyyMM-dd") + "','" + btarih.Value.ToString("yyyy-MM-dd") + "','" + posta.Text + "','" + cin.SelectedItem + "')");
                MessageBox.Show("Kayıt İşlemi Başarılı");
                Listele("select * from personel order by personel_id desc limit 3");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
