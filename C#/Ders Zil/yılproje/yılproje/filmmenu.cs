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
    public partial class filmmenu : Form
    {
        public filmmenu()
        {
            InitializeComponent();
        }
        public string film1;
        public string film2;

        private void filmmenu_Load(object sender, EventArgs e)
        {
            label3.Text = film1.ToString();
        }
    }
}
