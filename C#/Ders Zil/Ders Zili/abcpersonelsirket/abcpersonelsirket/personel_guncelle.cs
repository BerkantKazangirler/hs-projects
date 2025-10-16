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
    public partial class personel_guncelle : Form
    {
        public personel_guncelle()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;

        public void BilgiGetir(string sorgu)
        {
            baglanti.Open();
            MySqlCommand komut = new MySqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            MySqlDataReader cmd = komut.ExecuteReader();

            while(cmd.Read())
            {
                ad.Text = cmd["personel_adi"].ToString();
                soyad.Text = cmd["personel_soyadi"].ToString();
                dep.SelectedItem = cmd["departman"].ToString();
                rüt.SelectedItem = cmd["unvan"].ToString();
                masa.Text = cmd["maas"].ToString();
                posta.Text = cmd["eposta"].ToString();
                cin.SelectedItem = cmd["cinsiyet"].ToString();
                dtarih.Value = Convert.ToDateTime(cmd["dogum_tarihi"]);
               btarih.Value = Convert.ToDateTime(cmd["ise_baslama_tarihi"]);
            }
            baglanti.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (ad.Text == "" && soyad.Text == "" && dep.Text == "" && cin.Text == "" && rüt.Text == "" && masa.Text == "" && posta.Text == "")
            {
                MessageBox.Show("Boşluk Mevcut");
            }
            else
            {
                ESG("update personel set personel_adi='" + ad.Text + "', personel_soyadi = '" + soyad.Text + "',departman='" + dep.SelectedItem + "', unvan = '" + rüt.SelectedItem + "',maas='" + masa.Text + "',dogum_tarihi='" + dtarih.Value.ToString("yyyy-MM-dd") + "',ise_baslama_tarihi='" + btarih.Value.ToString("yyyy-MM-dd") + "',eposta='" + posta.Text + "',cinsiyet='" + cin.SelectedItem + "' where personel_id='" + textBox1.Text + "'");
                MessageBox.Show("Personel Güncellendi");
            }
        }

        private void personel_guncelle_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "sirketdb";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BilgiGetir("select * from personel where personel_id='" + textBox1.Text + "'");
        }
    }
}
