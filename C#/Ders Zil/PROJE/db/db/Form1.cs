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

namespace db
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
            dataGridView1.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        public void Ekle()
        {
            string sorgu = "Insert into araba_tbl (marka,model,yil) values (@araba_marka,@araba_model,@araba_yil)";
            komut = new MySqlCommand(sorgu, baglanti);
            if(textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                komut.Parameters.AddWithValue("@araba_marka", textBox1.Text);
                komut.Parameters.AddWithValue("@araba_model", textBox2.Text);
                komut.Parameters.AddWithValue("@araba_yil", comboBox1.SelectedItem);

                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
                Listele("Select * From araba_tbl");
                Temizle();
            }
            else
            {
                MessageBox.Show("Boş Yer Var");
            }
        }

        public void Sil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemine devam etmek istiyor musun?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog == DialogResult.Yes)
            {
                string sql_sil = "Delete from araba_tbl where araba_id=@araba_no";
                komut = new MySqlCommand(sql_sil, baglanti);
                komut.Parameters.AddWithValue("@araba_no", dataGridView1.CurrentRow.Cells["araba_id"].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele("Select * from araba_tbl");
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal");
            }
        }

        public void Guncelle()
        {
            string sql = "Update araba_tbl set marka=@araba_marka, model=@araba_model, yil=@araba_yil where araba_id=@araba_no";
            komut = new MySqlCommand(sql, baglanti);

            komut.Parameters.AddWithValue("@araba_no", int.Parse(dataGridView1.CurrentRow.Cells["araba_id"].Value.ToString()));
            komut.Parameters.AddWithValue("@araba_marka", textBox1.Text);
            komut.Parameters.AddWithValue("@araba_model", textBox2.Text);
            komut.Parameters.AddWithValue("@araba_yil", comboBox1.SelectedItem);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele("Select * from araba_tbl");
            MessageBox.Show("Kayıt Güncellendi");
        }

        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sorgu = "Select * from araba_tbl";
            Listele(sorgu);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string aranan = textBox3.Text;
            Listele("select * from araba_tbl where marka LIKE '" + aranan+"%'");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
