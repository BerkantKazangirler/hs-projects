using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abcproje
{
    public partial class koltuk : Form
    {
        public koltuk()
        {
            InitializeComponent();
        }
        public string kadıyedek;
        public int tam;
        public int orenci;
        string skoltuk = "";

        public string salon1;
        public string salon2;
        public string salon3;

        private void button1_Click(object sender, EventArgs e)
        {
            if(s1.Visible == true)
            {
                s1.Visible = false;
            }
            else
            {
                s1.Visible = true;
                groupBox4.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            a ana = new a();
            ana.ad = kadıyedek;
            ana.salon1 = salon1;
            ana.salon2 = salon2;
            ana.salon3 = salon3;
            ana.tam = Convert.ToInt32(tam);
            ana.orenci = Convert.ToInt32(orenci);
            ana.Show();
            this.Hide();
        }

        private void s2b_Click(object sender, EventArgs e)
        {
            if (groupBox4.Visible == true)
            {
                groupBox4.Visible = false;
            }
            else
            {
                groupBox4.Visible = true;
                s1.Visible = false;
            }
        }

        private void s1a1_Click(object sender, EventArgs e)
        {
            try
            {
                if(s1a1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a1";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void koltuk_Load(object sender, EventArgs e)
        {
            if(tam == 0 && orenci == 0)
            {
                label9.Visible = true;
            }
            else
            {
                label9.Visible = false;
            }
            if(label9.Visible == false)
            {
                s1b.Visible = true;
                s2b.Visible = true;
            }
            else
            {
                s1b.Visible = false;
                s2b.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int vpara = Convert.ToInt32(textBox1.Text);
            int oislem;
            int tislem;
            if(radioButton1.Checked == true) // Öğrenci
            {
                oislem = vpara - orenci;
                if(vpara < orenci)
                {
                    MessageBox.Show("Yetersiz Para Verildi");
                }
                else
                {
                    if (skoltuk == "s1a1")
                    {
                        s1a1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a2")
                    {
                        s1a2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a3")
                    {
                        s1a3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a4")
                    {
                        s1a4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a5")
                    {
                        s1a5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a6")
                    {
                        s1a6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a7")
                    {
                        s1a7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a8")
                    {
                        s1a8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a9")
                    {
                        s1a9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a10")
                    {
                        s1a10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a11")
                    {
                        s1a11.BackColor = Color.Red;
                    }

                    // B
                    if (skoltuk == "s1b1")
                    {
                        s1b1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b2")
                    {
                        s1b2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b3")
                    {
                        s1b3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b4")
                    {
                        s1b4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b5")
                    {
                        s1b5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b6")
                    {
                        s1b6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b7")
                    {
                        s1b7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b8")
                    {
                        s1b8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b9")
                    {
                        s1b9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b10")
                    {
                        s1b10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b11")
                    {
                        s1b11.BackColor = Color.Red;
                    }

                    // C
                    if (skoltuk == "s1c1")
                    {
                        s1c1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c2")
                    {
                        s1c2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c3")
                    {
                        s1c3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c4")
                    {
                        s1c4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c5")
                    {
                        s1c5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c6")
                    {
                        s1c6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c7")
                    {
                        s1c7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c8")
                    {
                        s1c8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c9")
                    {
                        s1c9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c10")
                    {
                        s1c10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c11")
                    {
                        s1c11.BackColor = Color.Red;
                    }

                    // D
                    if (skoltuk == "s1d1")
                    {
                        s1d1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d2")
                    {
                        s1d2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d3")
                    {
                        s1d3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d4")
                    {
                        s1d4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d5")
                    {
                        s1d5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d6")
                    {
                        s1d6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d7")
                    {
                        s1d7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d8")
                    {
                        s1d8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d9")
                    {
                        s1d9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d10")
                    {
                        s1d10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d11")
                    {
                        s1d11.BackColor = Color.Red;
                    }

                    // E
                    if (skoltuk == "s1e1")
                    {
                        s1e1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e2")
                    {
                        s1e2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e3")
                    {
                        s1e3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e4")
                    {
                        s1e4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e5")
                    {
                        s1e5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e6")
                    {
                        s1e6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e7")
                    {
                        s1e7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e8")
                    {
                        s1e8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e9")
                    {
                        s1e9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e10")
                    {
                        s1e10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e11")
                    {
                        s1e11.BackColor = Color.Red;
                    }
                    MessageBox.Show("Verilmesi Gereken Para Üstü : "+oislem.ToString());
                    groupBox3.Visible = false;
                    skoltuk = "";
                }   
            }
            else if (radioButton2.Checked == true) // Tam
            {
                tislem = vpara - tam;
                if (vpara < tam)
                {
                    MessageBox.Show("Yetersiz Para Verildi");
                }
                else
                {
                    if (skoltuk == "s1a1")
                    {
                        s1a1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a2")
                    {
                        s1a2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a3")
                    {
                        s1a3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a4")
                    {
                        s1a4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a5")
                    {
                        s1a5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a6")
                    {
                        s1a6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a7")
                    {
                        s1a7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a8")
                    {
                        s1a8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a9")
                    {
                        s1a9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a10")
                    {
                        s1a10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1a11")
                    {
                        s1a11.BackColor = Color.Red;
                    }

                    // B
                    if (skoltuk == "s1b1")
                    {
                        s1b1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b2")
                    {
                        s1b2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b3")
                    {
                        s1b3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b4")
                    {
                        s1b4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b5")
                    {
                        s1b5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b6")
                    {
                        s1b6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b7")
                    {
                        s1b7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b8")
                    {
                        s1b8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b9")
                    {
                        s1b9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b10")
                    {
                        s1b10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1b11")
                    {
                        s1b11.BackColor = Color.Red;
                    }

                    // C
                    if (skoltuk == "s1c1")
                    {
                        s1c1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c2")
                    {
                        s1c2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c3")
                    {
                        s1c3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c4")
                    {
                        s1c4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c5")
                    {
                        s1c5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c6")
                    {
                        s1c6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c7")
                    {
                        s1c7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c8")
                    {
                        s1c8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c9")
                    {
                        s1c9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c10")
                    {
                        s1c10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1c11")
                    {
                        s1c11.BackColor = Color.Red;
                    }

                    // D
                    if (skoltuk == "s1d1")
                    {
                        s1d1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d2")
                    {
                        s1d2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d3")
                    {
                        s1d3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d4")
                    {
                        s1d4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d5")
                    {
                        s1d5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d6")
                    {
                        s1d6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d7")
                    {
                        s1d7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d8")
                    {
                        s1d8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d9")
                    {
                        s1d9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d10")
                    {
                        s1d10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1d11")
                    {
                        s1d11.BackColor = Color.Red;
                    }

                    // E
                    if (skoltuk == "s1e1")
                    {
                        s1e1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e2")
                    {
                        s1e2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e3")
                    {
                        s1e3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e4")
                    {
                        s1e4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e5")
                    {
                        s1e5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e6")
                    {
                        s1e6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e7")
                    {
                        s1e7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e8")
                    {
                        s1e8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e9")
                    {
                        s1e9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e10")
                    {
                        s1e10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s1e11")
                    {
                        s1e11.BackColor = Color.Red;
                    }
                    MessageBox.Show("Verilmesi Gereken Para Üstü : " + tislem.ToString());
                    groupBox3.Visible = false;
                    skoltuk = "";
                }

            }
            else // Hiç Seçmememiş İse
            {
                MessageBox.Show("Bilet Kategorisini Seçmediniz");
            }
        }

        private void s1a2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a2";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a3";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a4";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a5";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a6";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a7";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a8_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a8";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a9";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a10_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a10";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1a11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1a11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1a11";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b1";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b2";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b3";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b4";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b5";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b6";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b7";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b8_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b8";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b9";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b10_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b10";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1b11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1b11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1b11";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c1";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }

        }

        private void s1c2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c2";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }

        }

        private void s1c3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c3";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c4";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c5";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c6";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c7";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c8_Click(object sender, EventArgs e)
        {
                try
                {
                    if (s1c8.BackColor == Color.Red)
                    {
                        MessageBox.Show("Bu Koltuk Zaten Satılmış");
                    }
                    else
                    {
                        skoltuk = "s1c8";
                        groupBox3.Visible = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
                }
            }

        private void s1c9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c9";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c10_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c10";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1c11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1c11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1c11";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d1";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d2";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d5";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d3";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d5";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d6";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d7";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d8_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d8";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d9";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d10_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d10";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1d11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1d11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1d11";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e1";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e2";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e3";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e4";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e5";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e6";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e7";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e8_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e8";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e9";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e10_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e10";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s1e11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s1e11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s1e11";
                    groupBox3.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2a1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2a1";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vpara = Convert.ToInt32(textBox2.Text);
            int oislem;
            int tislem;
            if (radioButton4.Checked == true) // Öğrenci
            {
                oislem = vpara - orenci;
                if (vpara < orenci)
                {
                    MessageBox.Show("Yetersiz Para Verildi");
                }
                else
                {
                    if (skoltuk == "s2a1")
                    {
                        s2a1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a2")
                    {
                        s2a2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a3")
                    {
                        s2a3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a4")
                    {
                        s2a4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a5")
                    {
                        s2a5.BackColor = Color.Red;
                    }

                    // B
                    if (skoltuk == "s2b1")
                    {
                        s2b1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b2")
                    {
                        s2b2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b3")
                    {
                        s2b3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b4")
                    {
                        s2b4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b5")
                    {
                        s2b5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b6")
                    {
                        s2b6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b7")
                    {
                        s2b7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b8")
                    {
                        s2b8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b9")
                    {
                        s2b9.BackColor = Color.Red;
                    }

                    // C
                    if (skoltuk == "s2c1")
                    {
                        s2c1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c2")
                    {
                        s2c2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c3")
                    {
                        s2c3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c4")
                    {
                        s2c4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c5")
                    {
                        s2c5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c6")
                    {
                        s2c6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c7")
                    {
                        s2c7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c8")
                    {
                        s2c8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c9")
                    {
                        s2c9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c10")
                    {
                        s2c10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c11")
                    {
                        s2c11.BackColor = Color.Red;
                    }

                    // D
                    if (skoltuk == "s2d1")
                    {
                        s2d1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d2")
                    {
                        s2d2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d3")
                    {
                        s2d3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d4")
                    {
                        s2d4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d5")
                    {
                        s2d5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d6")
                    {
                        s2d6.BackColor = Color.Red;
                    }
                    MessageBox.Show("Verilmesi Gereken Para Üstü : " + oislem.ToString());
                    groupBox5.Visible = false;
                    skoltuk = "";
                }
            }
            else if (radioButton3.Checked == true) // Tam
            {
                tislem = vpara - tam;
                if (vpara < tam)
                {
                    MessageBox.Show("Yetersiz Para Verildi");
                }
                else
                {
                    if (skoltuk == "s2a1")
                    {
                        s2a1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a2")
                    {
                        s2a2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a3")
                    {
                        s2a3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a4")
                    {
                        s2a4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2a5")
                    {
                        s2a5.BackColor = Color.Red;
                    }

                    // B
                    if (skoltuk == "s2b1")
                    {
                        s2b1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b2")
                    {
                        s2b2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b3")
                    {
                        s2b3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b4")
                    {
                        s2b4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b5")
                    {
                        s2b5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b6")
                    {
                        s2b6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b7")
                    {
                        s2b7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b8")
                    {
                        s2b8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2b9")
                    {
                        s2b9.BackColor = Color.Red;
                    }

                    // C
                    if (skoltuk == "s2c1")
                    {
                        s2c1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c2")
                    {
                        s2c2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c3")
                    {
                        s2c3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c4")
                    {
                        s2c4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c5")
                    {
                        s2c5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c6")
                    {
                        s2c6.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c7")
                    {
                        s2c7.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c8")
                    {
                        s2c8.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c9")
                    {
                        s2c9.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c10")
                    {
                        s2c10.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2c11")
                    {
                        s2c11.BackColor = Color.Red;
                    }

                    // D
                    if (skoltuk == "s2d1")
                    {
                        s2d1.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d2")
                    {
                        s2d2.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d3")
                    {
                        s2d3.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d4")
                    {
                        s2d4.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d5")
                    {
                        s2d5.BackColor = Color.Red;
                    }
                    if (skoltuk == "s2d6")
                    {
                        s2d6.BackColor = Color.Red;
                    }
                    MessageBox.Show("Verilmesi Gereken Para Üstü : " + tislem.ToString());
                    groupBox5.Visible = false;
                    skoltuk = "";
                }

            }
            else // Hiç Seçmememiş İse
            {
                MessageBox.Show("Bilet Kategorisini Seçmediniz");
            }
        }

        private void s2a2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2a2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2a2";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2a3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2a3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2a3";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2a4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2a4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2a4";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2a5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2a5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2a5";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b1";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b2";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b3";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b4";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b9";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b5";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b6";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b7";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2b8_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2b8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2b8";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c1";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c2";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c3";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c4";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c5";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c6";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c7_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c7.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c7";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c8_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c8.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c8";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c9_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c9.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c9";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c10_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c10.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c10";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2c11_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2c11.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2c11";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2d1_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2d1.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2d1";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2d2_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2d2.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2d2";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2d3_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2d3.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2d3";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2d4_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2d4.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2d4";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2d5_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2d5.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2d5";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }

        private void s2d6_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2d6.BackColor == Color.Red)
                {
                    MessageBox.Show("Bu Koltuk Zaten Satılmış");
                }
                else
                {
                    skoltuk = "s2d6";
                    groupBox5.Visible = true;
                }
            }
            catch
            {
                MessageBox.Show("Kod Bölümündeki Bir Hata Tetiklendi");
            }
        }
    }
}
