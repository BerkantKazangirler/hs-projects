using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yılproje
{
    public partial class sat : Form
    {
        public sat()
        {
            InitializeComponent();
        }
        public int tambilet;
        public int orenci;
        public string kullaniciadiyedek;
        string koltuk;
        int tpara;
        int salonbsatılan;
        int salonisatılan;

        private void sat_Load(object sender, EventArgs e)
        {
            if(label3.Text == "0" && label4.Text == "0")
            {
                label3.Text = "Ayarlanmadı";
                label4.Text = "Ayarlanmadı";
            }
            else
            {
                label3.Text = tambilet.ToString();
                label4.Text = orenci.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            saloniki.Visible = false;
            comboBox1.Items.Clear();
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("A" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("B" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("C" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("D" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("E" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("F" + i);
            }
            comboBox1.Items.Add("-----");
            if (salonbir.Visible == true)
            {
                salonbir.Visible = false;
            }
            else
            {
                salonbir.Visible = true;
            }
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button58_Click(object sender, EventArgs e)
        {
            if(tambilet == 0)
            {
                MessageBox.Show("Bilet Fiyatları Ayarlanmamış Satın Alım Yapılamaz!");
            }
            else
            {
                if (salonbir.Visible == true)
                {
                    if (comboBox1.Text == "A1")
                    {
                        if (a1.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A1";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A2")
                    {
                        if (a2.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A2";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A3")
                    {
                        if (a3.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A3";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A4")
                    {
                        if (a4.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A4";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A5")
                    {
                        if (a5.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A5";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A6")
                    {
                        if (a6.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A6";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A7")
                    {
                        if (a7.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A7";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A8")
                    {
                        if (a8.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A8";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A9")
                    {
                        if (a9.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A9";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B1")
                    {
                        if (b1.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B1";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B2")
                    {
                        if (b2.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B2";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B3")
                    {
                        if (b3.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B3";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B4")
                    {
                        if (b4.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B4";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B5")
                    {
                        if (b5.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B5";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B6")
                    {
                        if (b6.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B6";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B7")
                    {
                        if (b7.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B7";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B8")
                    {
                        if (b8.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B8";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B9")
                    {
                        if (b9.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B9";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C1")
                    {
                        if (c1.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C1";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C2")
                    {
                        if (c2.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C2";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C3")
                    {
                        if (c3.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C3";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C4")
                    {
                        if (c4.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C4";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C5")
                    {
                        if (c5.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C5";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C6")
                    {
                        if (c6.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C6";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C7")
                    {
                        if (c7.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C7";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C8")
                    {
                        if (c8.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C8";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C9")
                    {
                        if (c9.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C9";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D1")
                    {
                        if (d1.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D1";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D2")
                    {
                        if (d2.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D2";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D3")
                    {
                        if (d3.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D3";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D4")
                    {
                        if (d4.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D4";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D5")
                    {
                        if (d5.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D5";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D6")
                    {
                        if (d6.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C6";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D7")
                    {
                        if (d7.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C7";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D8")
                    {
                        if (d8.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D8";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D9")
                    {
                        if (d9.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D9";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E1")
                    {
                        if (e1.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E1";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E2")
                    {
                        if (e2.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E2";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E3")
                    {
                        if (e3.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E3";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E4")
                    {
                        if (e4.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E4";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E5")
                    {
                        if (e5.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E5";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E6")
                    {
                        if (e6.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E6";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E7")
                    {
                        if (e7.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E7";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E8")
                    {
                        if (e8.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E8";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E9")
                    {
                        if (e9.BackColor == Color.LightCoral)
                        {
                            koltuk = "E1";
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E9";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F1")
                    {
                        if (f1.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F1";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F2")
                    {
                        if (f2.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F2";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F3")
                    {
                        if (f3.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F3";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F4")
                    {
                        if (f4.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F4";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F5")
                    {
                        if (f5.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F5";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F6")
                    {
                        if (f6.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F6";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F7")
                    {
                        if (f7.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F7";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F8")
                    {
                        if (f8.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F8";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F9")
                    {
                        if (f9.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F9";
                            groupBox2.Visible = true;
                        }
                    }
                }
                if (saloniki.Visible == true)
                {
                    if (comboBox1.Text == "A1")
                    {
                        if (a11.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A11";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A2")
                    {
                        if (a22.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A22";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A3")
                    {
                        if (a33.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A33";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A4")
                    {
                        if (a44.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A44";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A5")
                    {
                        if (a55.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A55";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A6")
                    {
                        if (a66.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A66";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A7")
                    {
                        if (a77.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A77";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A8")
                    {
                        if (a88.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A88";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "A9")
                    {
                        if (a99.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "A99";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B1")
                    {
                        if (b11.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B11";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B2")
                    {
                        if (b22.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B22";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B3")
                    {
                        if (b33.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B33";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B4")
                    {
                        if (b44.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B44";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B5")
                    {
                        if (b55.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B55";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B6")
                    {
                        if (b66.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B66";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B7")
                    {
                        if (b77.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B77";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B8")
                    {
                        if (b88.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B88";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "B9")
                    {
                        if (b99.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "B99";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C1")
                    {
                        if (c11.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C11";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C2")
                    {
                        if (c22.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C22";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C3")
                    {
                        if (c33.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C33";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C4")
                    {
                        if (c44.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C44";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C5")
                    {
                        if (c55.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C55";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C6")
                    {
                        if (c66.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C66";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C7")
                    {
                        if (c77.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C77";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C8")
                    {
                        if (c88.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C88";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "C9")
                    {
                        if (c99.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C99";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D1")
                    {
                        if (d11.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D11";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D2")
                    {
                        if (d22.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D22";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D3")
                    {
                        if (d33.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D33";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D4")
                    {
                        if (d44.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D44";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D5")
                    {
                        if (d55.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D55";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D6")
                    {
                        if (d66.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C66";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D7")
                    {
                        if (d77.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "C77";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D8")
                    {
                        if (d88.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D88";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "D9")
                    {
                        if (d99.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "D99";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E1")
                    {
                        if (e11.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E11";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E2")
                    {
                        if (e22.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E22";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E3")
                    {
                        if (e33.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E33";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E4")
                    {
                        if (e44.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E44";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E5")
                    {
                        if (e55.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E55";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E6")
                    {
                        if (e66.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E66";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E7")
                    {
                        if (e77.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E77";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E8")
                    {
                        if (e88.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E88";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "E9")
                    {
                        if (e99.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "E99";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F1")
                    {
                        if (f11.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F11";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F2")
                    {
                        if (f22.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F22";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F3")
                    {
                        if (f33.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F33";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F4")
                    {
                        if (f44.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F44";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F5")
                    {
                        if (f55.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F55";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F6")
                    {
                        if (f66.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F66";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F7")
                    {
                        if (f77.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F77";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F8")
                    {
                        if (f88.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F88";
                            groupBox2.Visible = true;
                        }
                    }
                    if (comboBox1.Text == "F9")
                    {
                        if (f99.BackColor == Color.LightCoral)
                        {
                            MessageBox.Show("Bu Koltuk Dolu!");
                        }
                        else
                        {
                            koltuk = "F99";
                            groupBox2.Visible = true;
                        }
                    }
                }
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
                if (radioButton1.Checked == true)
                {
                    int opara;
                    int osatınal = int.Parse(textBox1.Text);
                    opara = osatınal - orenci;
                    if (osatınal < orenci)
                    {
                        MessageBox.Show("Bunu Alıcak Yeterli Parayı Vermemiş!");
                    }
                    if (salonbir.Visible == true)
                        {
                            // Öğrenci
                            if (koltuk == "A1")
                            {
                                a1.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "A2")
                            {
                                a2.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "A3")
                            {
                                a3.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "A4")
                            {
                                a4.BackColor = Color.LightCoral;
                                salonbsatılan++;
                           }
                            if (koltuk == "A5")
                            {
                                a5.BackColor = Color.LightCoral;
                               salonbsatılan++;
                            }
                            if (koltuk == "A6")
                            {
                                a6.BackColor = Color.LightCoral;
                               salonbsatılan++;
                           }
                            if (koltuk == "A7")
                            {
                                a7.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "A8")
                            {
                                a8.BackColor = Color.LightCoral;
                               salonbsatılan++;
                               }
                            if (koltuk == "A9")
                            {
                                a9.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "B1")
                            {
                                b1.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "B2")
                            {
                                b2.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "B3")
                            {
                                b3.BackColor = Color.LightCoral;
                               salonbsatılan++;
                            }
                            if (koltuk == "B4")
                            {
                                b4.BackColor = Color.LightCoral;
                               salonbsatılan++;
                            }
                            if (koltuk == "B5")
                            {
                                b5.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "B6")
                            {
                                b6.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "B7")
                            {
                                b7.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "B8")
                            {
                                b8.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "B9")
                            {
                                b9.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "C1")
                            {
                                c1.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "C2")
                            {
                                c2.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "C3")
                            {
                                c3.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "C4")
                            {
                                 c4.BackColor = Color.LightCoral;
                                 salonbsatılan++;
                            }
                            if (koltuk == "C5")
                            {
                                c5.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "C6")
                            {
                                c6.BackColor = Color.LightCoral;
                               salonbsatılan++;
                            }
                            if (koltuk == "C7")
                            {
                                c7.BackColor = Color.LightCoral;
                               salonbsatılan++;
                              }
                            if (koltuk == "C8")
                            {
                                c8.BackColor = Color.LightCoral;
                                salonbsatılan++;
                            }
                            if (koltuk == "C9")
                            {
                                c9.BackColor = Color.LightCoral;
                                 salonbsatılan++;
                             }
                            if (koltuk == "D1")
                            {
                                d1.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "D2")
                            {
                                d2.BackColor = Color.LightCoral;
                              salonbsatılan++;
                              }
                            if (koltuk == "D3")
                            {
                                d3.BackColor = Color.LightCoral;
                                 salonbsatılan++;
                             }
                            if (koltuk == "D4")
                            {
                                d4.BackColor = Color.LightCoral;
                                 salonbsatılan++;
                              }
                            if (koltuk == "D5")
                            {
                                d5.BackColor = Color.LightCoral;
                                salonbsatılan++;
                              }
                            if (koltuk == "D6")
                            {
                                d6.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "D7")
                            {
                                d7.BackColor = Color.LightCoral;
                               salonbsatılan++;
                            }
                            if (koltuk == "D8")
                            {
                                d8.BackColor = Color.LightCoral;
                             salonbsatılan++;
                              }
                            if (koltuk == "D9")
                            {
                                d9.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "E1")
                            {
                                e1.BackColor = Color.LightCoral;
                                 salonbsatılan++;
                             }
                            if (koltuk == "E2")
                            {
                                e2.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "E3")
                            {
                                e3.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "E4")
                            {
                                e4.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "E5")
                            {
                                e5.BackColor = Color.LightCoral;
                               salonbsatılan++;
                             }
                            if (koltuk == "E6")
                            {
                                e6.BackColor = Color.LightCoral;
                                salonbsatılan++;
                               }
                            if (koltuk == "E7")
                            {
                                e7.BackColor = Color.LightCoral;
                               salonbsatılan++;
                             }
                            if (koltuk == "E8")
                            {
                                e8.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "E9")
                            {
                                e9.BackColor = Color.LightCoral;
                               salonbsatılan++;
                             }
                            if (koltuk == "F1")
                            {
                                f1.BackColor = Color.LightCoral;
                               salonbsatılan++;
                             }
                            if (koltuk == "F2")
                            {
                                f2.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "F3")
                            {
                                f3.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "F4")
                            {
                                f4.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "F5")
                            {
                                f5.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "F6")
                            {
                                f6.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "F7")
                            {
                                f7.BackColor = Color.LightCoral;
                                 salonbsatılan++;
                            }
                            if (koltuk == "F8")
                            {
                                f8.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                            if (koltuk == "F9")
                            {
                                f9.BackColor = Color.LightCoral;
                                salonbsatılan++;
                             }
                        }
                        if (saloniki.Visible == true)
                        {
                            // Öğrenci
                            if (koltuk == "A11")
                            {
                                a11.BackColor = Color.LightCoral;
                        salonisatılan++;
                            }
                            if (koltuk == "A22")
                            {
                                a22.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A33")
                            {
                                a33.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A44")
                            {
                                a44.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A55")
                            {
                                a55.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A66")
                            {
                                a66.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A77")
                            {
                                a77.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A88")
                            {

                                a88.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "A99")
                            {
                                a99.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B11")
                            {
                                b11.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B22")
                            {
                                b22.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B33")
                            {
                                b33.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B44")
                            {
                                b44.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B55")
                            {
                                b55.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B66")
                            {
                                b66.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B77")
                            {
                                b77.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B88")
                            {
                                b88.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "B99")
                            {
                                b99.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C11")
                            {
                                c11.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C22")
                            {
                                c22.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C33")
                            {
                                c33.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C44")
                            {
                                c44.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C55")
                            {
                                c55.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C66")
                            {
                                c66.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C77")
                            {
                                c77.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C88")
                            {
                                c88.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "C99")
                            {
                                c99.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D11")
                            {
                                d11.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D22")
                            {
                                d22.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D33")
                            {
                                d33.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D44")
                            {
                                d44.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D55")
                            {
                                d55.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D66")
                            {
                                d66.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D77")
                            {
                                d77.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D88")
                            {
                                d88.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "D99")
                            {
                                d99.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E11")
                            {
                                e11.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E22")
                            {
                                e22.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E33")
                            {
                                e33.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E44")
                            {
                                e44.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E55")
                            {
                                e55.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E66")
                            {
                                e66.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E77")
                            {
                                e77.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E88")
                            {
                                e88.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "E99")
                            {
                                e99.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F11")
                            {
                                f11.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F22")
                            {
                                f22.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F33")
                            {
                                f33.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F44")
                            {
                                f44.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F55")
                            {
                                f55.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F66")
                            {
                                f66.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F77")
                            {
                                f77.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F88")
                            {
                                f88.BackColor = Color.LightCoral;
                        salonisatılan++;
                    }
                            if (koltuk == "F99")
                            {
                                f99.BackColor = Color.LightCoral;
                                salonisatılan++;
                             }
                }
                MessageBox.Show("Para Üstü :" + opara);
            }
                else
                {
                    int tparaal = int.Parse(textBox1.Text);
                    tpara = tparaal - tambilet;
                    if (tparaal < tambilet)
                    {
                        MessageBox.Show("Bunu Alıcak Yeterli Parayı Vermemiş!");
                    }
                    if (salonbir.Visible == true)
                        {
                            // Tam
                            if (koltuk == "A1")
                            {
                                a1.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A2")
                            {
                                a2.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A3")
                            {
                                a3.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A4")
                            {
                                a4.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A5")
                            {
                                a5.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A6")
                            {
                                a6.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A7")
                            {
                                a7.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A8")
                            {
                                a8.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A9")
                            {
                                a9.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B1")
                            {
                                b1.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B2")
                            {
                                b2.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B3")
                            {
                                b3.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B4")
                            {
                                b4.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B5")
                            {
                                b5.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B6")
                            {
                                b6.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B7")
                            {
                                b7.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B8")
                            {
                                b8.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B9")
                            {
                                b9.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C1")
                            {
                                c1.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C2")
                            {
                                c2.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C3")
                            {
                                c3.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C4")
                            {
                                c4.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C5")
                            {
                                c5.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C6")
                            {
                                c6.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C7")
                            {
                                c7.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C8")
                            {
                                c8.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C9")
                            {
                                c9.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D1")
                            {
                                d1.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D2")
                            {
                                d2.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D3")
                            {
                                d3.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D4")
                            {
                                d4.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D5")
                            {
                                d5.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D6")
                            {
                                d6.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D7")
                            {
                                d7.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D8")
                            {
                                d8.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D9")
                            {
                                d9.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E1")
                            {
                                e1.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E2")
                            {
                                e2.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E3")
                            {
                                e3.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E4")
                            {
                                e4.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E5")
                            {
                                e5.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E6")
                            {
                                e6.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E7")
                            {
                                e7.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E8")
                            {
                                e8.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E9")
                            {
                                e9.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F1")
                            {
                                f1.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F2")
                            {
                                f2.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F3")
                            {
                                f3.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F4")
                            {
                                f4.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F5")
                            {
                                f5.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F6")
                            {
                                f6.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F7")
                            {
                                f7.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F8")
                            {
                                f8.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F9")
                            {
                                f9.BackColor = Color.LightCoral;
                            }
                        }
                        if (saloniki.Visible == true)
                        {
                            // Öğrenci
                            if (koltuk == "A11")
                            {
                                a11.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A22")
                            {
                                a22.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A33")
                            {
                                a33.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A44")
                            {
                                a44.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A55")
                            {
                                a55.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A66")
                            {
                                a66.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A77")
                            {
                                a77.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A88")
                            {
                                a88.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "A99")
                            {
                                a99.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B11")
                            {
                                b11.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B22")
                            {
                                b22.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B33")
                            {
                                b33.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B44")
                            {
                                b44.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B55")
                            {
                                b55.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B66")
                            {
                                b66.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B77")
                            {
                                b77.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B88")
                            {
                                b88.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "B99")
                            {
                                b99.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C11")
                            {
                                c11.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C22")
                            {
                                c22.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C33")
                            {
                                c33.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C44")
                            {
                                c44.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C55")
                            {
                                c55.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C66")
                            {
                                c66.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C77")
                            {
                                c77.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C88")
                            {
                                c88.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "C99")
                            {
                                c99.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D11")
                            {
                                d11.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D22")
                            {
                                d22.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D33")
                            {
                                d33.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D44")
                            {
                                d44.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D55")
                            {
                                d55.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D66")
                            {
                                d66.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D77")
                            {
                                d77.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D88")
                            {
                                d88.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "D99")
                            {
                                d99.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E11")
                            {
                                e11.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E22")
                            {
                                e22.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E33")
                            {
                                e33.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E44")
                            {
                                e44.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E55")
                            {
                                e55.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E66")
                            {
                                e66.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E77")
                            {
                                e77.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E88")
                            {
                                e88.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "E99")
                            {
                                e99.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F11")
                            {
                                f11.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F22")
                            {
                                f22.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F33")
                            {
                                f33.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F44")
                            {
                                f44.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F55")
                            {
                                f55.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F66")
                            {
                                f66.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F77")
                            {
                                f77.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F88")
                            {
                                f88.BackColor = Color.LightCoral;
                            }
                            if (koltuk == "F99")
                            {
                                f99.BackColor = Color.LightCoral;
                            }
                        }
                MessageBox.Show("Para Üstü :" + tpara);
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("A"+i);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {

        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {

        }

        private void button51_Click(object sender, EventArgs e)
        {
            
        }

        private void button57_Click(object sender, EventArgs e)
        {
            
        }

        private void button60_Click_2(object sender, EventArgs e)
        {
            int para;
            int satınal = int.Parse(textBox1.Text);
            para = satınal - orenci;
            MessageBox.Show(para.ToString());
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            //koltuk = "B1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            
        }

        private void b3_Click(object sender, EventArgs e)
        {
            
        }

        private void b4_Click(object sender, EventArgs e)
        {
            
        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void b6_Click(object sender, EventArgs e)
        {

        }

        private void b7_Click(object sender, EventArgs e)
        {

        }

        private void b8_Click(object sender, EventArgs e)
        {

        }

        private void b9_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
        }

        private void button31_Click(object sender, EventArgs e)
        {
            
        }

        private void button37_Click(object sender, EventArgs e)
        {
            
        }

        private void button43_Click(object sender, EventArgs e)
        {
            
        }

        private void button49_Click(object sender, EventArgs e)
        {
            
        }

        private void button55_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            salonbir.Visible = false;
            comboBox1.Items.Clear();
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("A" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("B" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("C" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("D" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("E" + i);
            }
            comboBox1.Items.Add("-----");
            for (int i = 1; i <= 9; i++)
            {
                comboBox1.Items.Add("F" + i);
            }
            comboBox1.Items.Add("-----");
            if (saloniki.Visible == true)
            {
                saloniki.Visible = false;
            }
            else
            {
                saloniki.Visible = true;
            }
            if (groupBox1.Visible == true)
            {
                groupBox1.Visible = false;
            }
            else
            {
                groupBox1.Visible = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            anagiris menü = new anagiris();
            menü.kullaniciadi = kullaniciadiyedek;
            menü.satılanbilet1 = salonbsatılan;
            menü.satılanbilet2 = salonisatılan;
            menü.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(salonbsatılan.ToString());
        }
    }
}
