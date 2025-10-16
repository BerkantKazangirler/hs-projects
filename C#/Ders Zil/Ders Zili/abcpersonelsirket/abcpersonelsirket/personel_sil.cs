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
    public partial class personel_sil : Form
    {
        public personel_sil()
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

        private void personel_sil_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "sirketdb";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele("select * from personel where personel_id=" + textBox1.Text + "");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme İşlemine Devam Etmek İstiyormusunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog ==DialogResult.Yes)
            {
                ESG("delete from personel where personel_id='" + dataGridView1.CurrentRow.Cells["personel_id"].Value.ToString() + "'");
                Listele("select * from personel");
                MessageBox.Show("Personel Silindi");
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
            }
        }
    }
}
