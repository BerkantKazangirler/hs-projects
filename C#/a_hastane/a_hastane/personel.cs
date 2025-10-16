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

namespace a_hastane
{
    public partial class personel : Form
    {
        public personel()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter veriler;
        DataTable tbl;

        private void personel_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "hastane";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
            timer1.Start();
            Listele("select personel_id as Personel_Numarası, personel_adısoyadı as Personel_Adı_Soyadı, personel_yaş as Personel_Yaşı, personel_rütbe as Rütbe, personel_bölüm as Bulunduğu_Bölüm, personel_cinsiyet as Cinsiyet, personel_giriş as İşe_Başlama_Tarihi from personel");
        }

        public DataTable Listele(string sorgu)
        {
            tbl = new DataTable();
            baglanti.Open();
            veriler = new MySqlDataAdapter(sorgu, baglanti);
            veriler.Fill(tbl);
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        public void Ekle()
        {
            if (textBox1.Text == "" && textBox2.Text == "" && comboBox3.Text == "" && comboBox2.Text == "" && comboBox1.Text == "")
            {
                MessageBox.Show("Boş Yer Mevcut", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sorgu = "Insert into personel (personel_adısoyadı,personel_yaş,personel_rütbe,personel_bölüm,personel_cinsiyet,personel_giriş) values (@personel_adısoyadı,@personel_yaş,@personel_rütbe,@personel_bölüm,@personel_cinsiyet,@personel_giriş)";
                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@personel_adısoyadı", textBox1.Text);
                komut.Parameters.AddWithValue("@personel_yaş", textBox2.Text);
                komut.Parameters.AddWithValue("@personel_rütbe", comboBox3.SelectedItem);
                komut.Parameters.AddWithValue("@personel_bölüm", comboBox2.SelectedItem);
                komut.Parameters.AddWithValue("@personel_cinsiyet", comboBox1.SelectedItem);
                komut.Parameters.AddWithValue("@personel_giriş", DateTime.Now.ToLongTimeString());

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
                Listele("Select * From personel");
                Temizle();
            }
        }

        public void Sil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemine devam etmek istiyor musun?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string sql_sil = "Delete from personel where personel_id=@personel_id";
                komut = new MySqlCommand(sql_sil, baglanti);
                komut.Parameters.AddWithValue("@personel_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele("Select * from personel");
                MessageBox.Show("Başarıyla Personel Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
            }
        }

        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 ana = new Form1();
            ana.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sil();
        }
    }
}
