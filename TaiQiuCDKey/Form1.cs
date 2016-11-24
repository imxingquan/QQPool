using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TQ;

namespace TaiQiuCDKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string key = textBox1.Text.Trim();

            CdKeyTools tools = new CdKeyTools();
            textBox2.Text = tools.GetCdKey(key);
        }
    }
}
