using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CofffeeStoreManagement.Util;

namespace CofffeeStoreManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Hide();//ẩn form login
            main.ShowDialog();//show top most form main 
            this.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageUtil.ShowMessage("QUES_1001", MessageBoxButtons.OKCancel, this.Text);
            if(result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

    }
}
