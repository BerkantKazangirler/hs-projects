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
    public partial class personel_listele : Form
    {
        public personel_listele()
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



        private void personel_listele_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "sirketdb";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Listele("select * from personel");
            }
            else
            {
                Listele("select * from personel");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Listele("select * from personel where cinsiyet='Erkek'"); // Yapacuz
                //Listele("select * as 'Cinsiyeti Erkek Olan Personel' from personel where cinsiyet='Erkek'");
            }
            else
            {
                Listele("select * from personel where cinsiyet='Erkek'");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Listele("select MIN(maas) as 'En Düşük Maaş' from personel");
            }
            else
            {
                Listele("select MIN(maas) from personel");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Listele("select MAX(maas) as 'En Düşük Maaş' from personel");
            }
            else
            {
                Listele("select MAX(maas) from personel");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Listele("select * from personel where cinsiyet='Kadın'"); // Yapacuz
            }
            else
            {
                Listele("select * from personel where cinsiyet='Kadın'");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                Listele("select SUM(maas) as 'Toplam Maas' from personel");
            }
            else
            {
                Listele("select SUM(maas) from personel");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string secim = comboBox1.SelectedItem.ToString();
            if(checkBox1.Checked)
            {
                Listele("select * from personel where departman='" + secim + "'"); // Yapacuz
            }
            else
            {
                Listele("select * from personel where departman='" + secim + "'");
            }
        }
    }
}
