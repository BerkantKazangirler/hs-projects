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

namespace WindowsFormsApplication1
{
    public partial class yönetim : Form
    {
        public yönetim()
        {
            InitializeComponent();
        }

        MySqlConnection baglanti = new MySqlConnection("Server=localhost;Database=emlak;Uid=root;Pwd='123456'");
        MySqlCommand komut;
        MySqlDataAdapter veriler;
        DataTable tbl;

        int kuralgirdimi = 0;
        public DataTable Listele(string sorgu)
        {
            tbl = new DataTable();
            baglanti.Open();
            veriler = new MySqlDataAdapter(sorgu, baglanti);
            veriler.Fill(tbl);
            dataGridView1.DataSource = tbl;
            dataGridView2.DataSource = tbl;
            baglanti.Close();
            return tbl;
        }

        public void Ekle()
        {
            string sorgu = "Insert into yönetim (yönetim_ad,yönetim_sifre,yönetim_cinsiyet,yönetim_is,girdi,eklenmetarihi) values (@yönetim_ad,@yönetim_sifre,@yönetim_cinsiyet,@yönetim_is,@girdi,@eklenmetarihi)";
            komut = new MySqlCommand(sorgu, baglanti);
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    MessageBox.Show("İş Bölümünü Seçmediniz","Uyarı" , MessageBoxButtons.OK,MessageBoxIcon.Error);

                }
                else
                {
                    if(kuralgirdimi == 0)
                    {
                        MessageBox.Show("Kurallara Girmeden Sallama Yapmayınız!","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if(checkBox1.Checked == false)
                        {
                            MessageBox.Show("Kuralları Tiklemediniz", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@yönetim_ad", textBox1.Text);
                            komut.Parameters.AddWithValue("@yönetim_sifre", textBox2.Text);
                            if(radioButton4.Checked == true && radioButton5.Checked == false)
                            {
                                komut.Parameters.AddWithValue("@yönetim_cinsiyet", radioButton4.Text);
                            }
                            else if(radioButton4.Checked == false && radioButton5.Checked == true)
                            {
                                komut.Parameters.AddWithValue("@yönetim_cinsiyet", radioButton5.Text);
                            }
                            if(radioButton1.Checked == true && radioButton2.Checked == false && radioButton3.Checked == false)
                             {
                                komut.Parameters.AddWithValue("@yönetim_is", radioButton1.Text);
                             }
                            else if(radioButton1.Checked == false && radioButton2.Checked == true && radioButton3.Checked == false)
                            {
                                komut.Parameters.AddWithValue("@yönetim_is", radioButton2.Text);
                            }
                            else
                            {
                                komut.Parameters.AddWithValue("@yönetim_is", radioButton3.Text);
                            }
                            komut.Parameters.AddWithValue("@girdi", "Yok");
                            komut.Parameters.AddWithValue("@eklenmetarihi", DateTime.Now.ToShortDateString().ToString());

                            baglanti.Open();
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                            MessageBox.Show("Personel Kaydı Eklendi", "Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            Listele("Select yönetim_id as Personel Numarası, yönetim_ad as Personel Adı Soyadı, yönetim_sifre as Personel Şifre, yönetim_cinsiyet as Personel Cinsiyet, yönetim_is as Personel İş Bölümü, girdi as Daha Önce Girdimi, eklenmetarihi as Eklenme Tarihi From yönetim");
                            Temizle();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Boş Yer Mevcut Kayıt Eklenemedi", "Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Sil()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Silme işlemine devam etmek istiyor musun?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string sql_sil = "Delete from yönetim where yönetim_id=@yönetim_id";
                komut = new MySqlCommand(sql_sil, baglanti);
                komut.Parameters.AddWithValue("@yönetim_id", dataGridView1.CurrentRow.Cells["yönetim_id"].Value.ToString());
                baglanti.Open();
                komut.ExecuteNonQuery();
                baglanti.Close();
                Listele("Select yönetim_id as Personel_Numarası, yönetim_ad as Personel_Adı_Soyadı, yönetim_sifre as Personel_Şifre, yönetim_cinsiyet as Personel_Cinsiyet, yönetim_is as Personel_İş_Bölümü, girdi as Daha_Önce_Girdimi, eklenmetarihi as Eklenme_Tarihi From yönetim");
                MessageBox.Show("Personel Silindi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Çık()
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Çıkmak istediğinize emin misiniz?", "ABC Emlak", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        public void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            checkBox1.Checked = false;
            kuralgirdimi = 0;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tabControl1.Visible == true)
            {
                tabControl1.Visible = false;
            }
            else
            {
                tabControl1.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ekle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://sites.google.com/view/abc-emlak-test/ana-sayfa");
            kuralgirdimi++;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_VisibleChanged(object sender, EventArgs e)
        {
            Listele("Select yönetim_id as Personel_Numarası, yönetim_ad as Personel_Adı_Soyadı, yönetim_sifre as Personel_Şifre, yönetim_cinsiyet as Personel_Cinsiyet, yönetim_is as Personel_İş_Bölümü, girdi as Daha_Önce_Girdimi, eklenmetarihi as Eklenme_Tarihi From yönetim");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sil();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listele("Select yönetim_id as Personel_Numarası, yönetim_ad as Personel_Adı_Soyadı, yönetim_sifre as Personel_Şifre, yönetim_cinsiyet as Personel_Cinsiyet, yönetim_is as Personel_İş_Bölümü, girdi as Daha_Önce_Girdimi, eklenmetarihi as Eklenme_Tarihi From yönetim");
        }

        private void yönetim_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Çık();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
