using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a_okul
{
    public partial class yönetimpanel : Form
    {
        public yönetimpanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(öğrencigir.Visible == true)
            {
                label4.Visible = true;
                öğrencigir.Visible = false;
                groupBox2.Visible = false;
            }
            else
            {
                label4.Visible = false;
                öğrencigir.Visible = true;
                groupBox2.Visible = true;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
