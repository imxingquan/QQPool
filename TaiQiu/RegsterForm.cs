using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace TQ
{
    public partial class RegsterForm : Form
    {
        public RegsterForm()
        {
            InitializeComponent();

        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            string cdkey = keyTextBox.Text.Trim();

            //比较key是否正确
            if (SoftRegister(cdkey))
            {
                MessageBox.Show("注册成功!,请重启软件!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("注册码不正确!");
            }
        }

        private void Regster_Load(object sender, EventArgs e)
        {
            ICkKey k = new CdKeyTools();
            unameTextBox.Text = k.Seeds.ToUpper();
        }

        private bool SoftRegister(string cdkey)
        {
            CdKeyTools tools = new CdKeyTools();
            string  mykey = tools.GetCdKey();
            if (cdkey == mykey)
            {
                //写注册表
                tools.WriteRegister(cdkey);
                return true;
            }
            return false;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
