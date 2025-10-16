using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElemanSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = "";
            string soyad = "";
            string tamad;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            tamad = ad + " " + soyad;
            listBox1.Items.Add(tamad);
        }

        private void button2_Click(object sender, EventArgs e)
        {;
            if(listBox1.Items.Count == 0)
            {
                MessageBox.Show("Zaten Boş");
            }
            else
            {
                MessageBox.Show("Temizlendi");
                listBox1.Items.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ad;
            string soyad;
            string tamad;
        }
    }
}
