using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sitekaynakkodualma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient cli = new WebClient();
            Application.DoEvents();
            var gelen = cli.DownloadString(textBox2.Text);
            textBox1.Text = gelen;
        }
    }
}
