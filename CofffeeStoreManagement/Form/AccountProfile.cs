using CofffeeStoreManagement.DAO;
using CofffeeStoreManagement.DTO;
using CofffeeStoreManagement.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofffeeStoreManagement
{
    public partial class AccountProfile : Form
    {
        private AccountDTO accountDTO;
        public AccountProfile(AccountDTO acc)
        {
            this.accountDTO = acc;
            InitializeComponent();
        }

        private void AccountProfile_Load(object sender, EventArgs e)
        {
            DisplayAcount();
        }

        #region Validate
        private bool IsCheckNull()
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "ユーザー名");
                txtUserName.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "パスワード");
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private bool CheckPassword(string oldPassword, string newPassword, string ReenterNewPassword)
        {
            Validate validate = new Validate();
            if (!validate.ValidatePassword(newPassword) && !string.IsNullOrEmpty(newPassword))
            {
                MessageUtil.ShowMessage("ERR_2008", MessageBoxButtons.OK, this.Text);
                return false;
            }
            if (!newPassword.Equals(ReenterNewPassword))
            {
                MessageUtil.ShowMessage("ERR_2009", MessageBoxButtons.OK, this.Text);
                return false;
            }
            if (newPassword.Equals(oldPassword) && !string.IsNullOrEmpty(newPassword))
            {
                MessageUtil.ShowMessage("ERR_2010", MessageBoxButtons.OK, this.Text);
                return false;
            }
            return true;
        }
        #endregion
        private void DisplayAcount()
        {
            txtUserName.Text = accountDTO.userName;
            txtDisplayName.Text = accountDTO.displayName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!IsCheckNull())
            {
                return;
            }
            // Lay thong tin account hien tai
            AccountDTO accountDTO = AccountDAO.Instance.GetAccoutByUserName(txtUserName.Text);
            if (accountDTO == null)
            {
                return;
            }
            else
            {
                DialogResult result = MessageUtil.ShowMessage("QUES_1005", MessageBoxButtons.OKCancel, this.Text);
                if (result == DialogResult.OK)
                {
                    if(!CheckPassword(accountDTO.password, txtNewPassword.Text, txtRe_NewPassword.Text))
                    {
                        return;
                    }
                    string newPassword = txtNewPassword.Text.Trim();
                    int resultUpdate = AccountDAO.Instance.UpdateAccount(txtUserName.Text, txtDisplayName.Text, txtPassword.Text, txtNewPassword.Text);
                    if (resultUpdate > 0)
                    {
                        MessageUtil.ShowMessage("INF_3003", MessageBoxButtons.OK, this.Text);
                    }
                    else
                    {
                        MessageUtil.ShowMessage("ERR_2011", MessageBoxButtons.OK, this.Text);
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
