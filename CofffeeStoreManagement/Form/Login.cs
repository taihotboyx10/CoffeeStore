using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CofffeeStoreManagement.DAO;
using CofffeeStoreManagement.DTO;
using CofffeeStoreManagement.Util;

namespace CofffeeStoreManagement
{
    public partial class Login : Form
    {
        bool passwordShow;
        Timer timer = new Timer();
        int loginError;
        public Login()
        {
            InitializeComponent();
            timer.Interval = 800;
            timer.Tick += Timer_Tick;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        #region Validate
        private bool CheckNull()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                txtUserName.Focus();
                lblMessage.Text = Constant.USERNAME_MESSAGE;
                lblMessage.Visible = true;
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Focus();
                lblMessage.Text = Constant.PWD_MESSAGE;
                lblMessage.Visible = true;
                return false;
            }
            return true;

        }

        //su kien textchange de xoa lblMessage 
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }

        //su kien textchange de xoa lblMessage 
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblMessage.Visible = false;
        }
        #endregion

        //Check username hop le
        private bool CheckUserName()
        {
            List<string> userNameLists = AccountDAO.Instance.GetUserNameList();
            
            return (userNameLists.Contains(txtUserName.Text));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validate
            if(!CheckNull())
            {
                return;
            }

            // Check 5 lan tro len hay khong
            if (CheckUserName() && AccountDAO.Instance.CheckLoginError(txtUserName.Text))
            {
                MessageUtil.ShowMessage("ERR_2014", MessageBoxButtons.OK, this.Text);
            }

            bool result = AccountDAO.Instance.CheckAccount(txtUserName.Text, txtPassword.Text);
            if (result) // login thanhcong
            {
                loginError = 0;
                AccountDTO accountDTO = AccountDAO.Instance.GetAccountByUserName(txtUserName.Text);
                Main main = new Main(accountDTO);
                main.Show();
                this.Hide();
            }
            else // login that bai
            {
                if (CheckUserName())
                {
                    loginError++;
                }
                MessageUtil.ShowMessage("ERR_2003", MessageBoxButtons.OK, this.Text);
            }

            // Neu that bai qua 5 lan thi luu vao db
            if (CheckUserName() && loginError >= 5)
            {
                AccountDAO.Instance.UpdateLogginError(txtUserName.Text);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageUtil.ShowMessage("QUES_1001", MessageBoxButtons.OKCancel, this.Text);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            passwordShow = false;
            txtPassword.PasswordChar = '*'; // Ẩn mật khẩu
            timer.Stop(); // Dừng Timer
        }
       
        private void btnPasswordShow_Click(object sender, EventArgs e)
        {
            passwordShow = true;
            txtPassword.PasswordChar = '\0'; // Hiển thị mật khẩu
            timer.Start(); // Bắt đầu Timer
        }
    }
}
