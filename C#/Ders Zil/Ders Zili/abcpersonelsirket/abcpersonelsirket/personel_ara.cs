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
    public partial class personel_ara : Form
    {
        public personel_ara()
        {
            InitializeComponent();
        }
        MySqlConnectionStringBuilder build = new MySqlConnectionStringBuilder();
        public MySqlConnection baglanti;

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
        private void personel_ara_Load(object sender, EventArgs e)
        {
            build.Server = "localhost";
            build.UserID = "root";
            build.Database = "sirketdb";
            build.Password = "123456";
            baglanti = new MySqlConnection(build.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele("select * from personel where personel_adi like '%" + textBox1.Text + "%'");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Listele("select * from personel where personel_adi like '%" + textBox1.Text + "%'");
        }
    }
}
