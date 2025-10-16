using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcpersonelsirket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string sefam = "31";

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            personel_listele listele = new personel_listele();
            listele.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personel_ekle ekle = new personel_ekle();
            ekle.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personel_sil sil = new personel_sil();
            sil.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            personel_guncelle update = new personel_guncelle();
            update.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            personel_ara ara = new personel_ara();
            ara.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            istatislik ista = new istatislik();
            ista.Show();
        }
    }
}
