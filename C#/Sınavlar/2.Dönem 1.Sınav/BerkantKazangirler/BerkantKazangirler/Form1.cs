using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BerkantKazangirler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(toolStripTextBox1.Text);
            i++;
            dataGridView2.Rows.Add(i, toolStripTextBox1.Text, DateTime.Now.ToLongTimeString());
            label1.Visible = true;
            label1.Text = "Aratılan Site : "+toolStripTextBox1.Text;
            label1.ForeColor = Color.CadetBlue;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
            toolStripTextBox1.Text = "";
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com.tr");
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(toolStripTextBox1.Text);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "www.e-okul.meb.gov.tr";
            webBrowser1.Navigate("e-okul.meb.gov.tr");
            i++;
            label1.Visible = true;
            label1.Text = "Aratılan Site : " + toolStripTextBox1.Text;
            label1.ForeColor = Color.CadetBlue;
            dataGridView2.Rows.Add(i, toolStripTextBox1.Text, DateTime.Now.ToLongTimeString());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "www.eba.gov.tr";
            i++;
            webBrowser1.Navigate("www.eba.gov.tr");
            label1.Visible = true;
            label1.Text = "Aratılan Site : " + toolStripTextBox1.Text;
            label1.ForeColor = Color.CadetBlue;
            dataGridView2.Rows.Add(i, toolStripTextBox1.Text, DateTime.Now.ToLongTimeString());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "www.ahievran.meb.k12.tr";
            i++;
            webBrowser1.Navigate("www.ahievran.meb.k12.tr");
            dataGridView2.Rows.Add(i, toolStripTextBox1.Text, DateTime.Now.ToLongTimeString());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "www.meb.gov.tr";
            webBrowser1.Navigate("www.meb.gov.tr");
            label1.Visible = true;
            label1.Text = "Aratılan Site : " + toolStripTextBox1.Text;
            label1.ForeColor = Color.CadetBlue;
            i++;
            dataGridView2.Rows.Add(i, toolStripTextBox1.Text, DateTime.Now.ToLongTimeString());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = "Saat : "+ DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void geriGelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }
    }
}
