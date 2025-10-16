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
    public partial class hastakayıt : Form
    {
        public hastakayıt()
        {
            InitializeComponent();
        }

        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        MySqlConnection baglanti;
        MySqlCommand komut;
        MySqlDataAdapter veriler;
        DataTable tbl;

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
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && comboBox2.Text == "" && comboBox1.Text == "" && textBox4.Text == "")
            {
                MessageBox.Show("Boş Yer Mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string sorgu = "Insert into olaylar (olay_adsoyad,olay_yaş,olay_cinsiyet,olay_ilaç,olay_reçete,olay_acıklama) values (@olay_adsoyad,@olay_yaş,@olay_cinsiyet,@olay_ilaç,@olay_reçete,@olay_acıklama)";
                komut = new MySqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@olay_adsoyad", textBox1.Text);
                komut.Parameters.AddWithValue("@olay_yaş", textBox2.Text);
                komut.Parameters.AddWithValue("@olay_cinsiyet", comboBox1.SelectedItem);
                komut.Parameters.AddWithValue("@olay_ilaç", comboBox2.SelectedItem);
                komut.Parameters.AddWithValue("@olay_reçete", textBox4.Text);
                komut.Parameters.AddWithValue("@olay_acıklama", textBox3.Text);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Olay Eklendi");
                Listele("Select * From olaylar");
                Temizle();
            }
        }

        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox2.Text = "";
            comboBox1.Text = "";
            textBox4.Text = "";
        }

        private void hastakayıt_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "hastane";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
            timer1.Start();
            Listele("select * from olaylar");
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
    }
}
