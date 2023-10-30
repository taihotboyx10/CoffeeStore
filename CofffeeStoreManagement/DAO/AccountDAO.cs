using CofffeeStoreManagement.DTO;
using CofffeeStoreManagement.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance 
        {
            get 
            { 
                if(instance == null)
                {
                    instance = new AccountDAO();
                }
                return instance;
            }
            private set => instance = value; 
        }
        private AccountDAO() { }

        public bool CheckAccount(string userName, string pwd)
        {
            string query = $"Usp_Login @user_name , @password";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, pwd });
            return dt.Rows.Count > 0;
        }

        public AccountDTO GetAccountByUserName(string userName)
        {
            AccountDTO accountDTO = new AccountDTO();
            string query = $"select * from account where user_name = '{userName}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                accountDTO.userName = item[0].ToString();
                accountDTO.displayName = item[1].ToString();
                accountDTO.password = item[2].ToString();
                accountDTO.accountType = Convert.ToInt16(item[3]);

                return accountDTO;
            }
            return null;
        }

        public AccountDTO GetAccoutByUserName(string userName)
        {
            AccountDTO accountDTO = new AccountDTO();
            string query = $"select * from account where user_name = '{userName}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dt.Rows)
            {
                accountDTO.userName = item[0].ToString();
                accountDTO.displayName= item[1].ToString();
                accountDTO.password= item[2].ToString();
            }

            return accountDTO;
        }

        public int UpdateAccount(string userName, string displayName, string oldPassword, string newPassword = "") 
        {

            if (string.IsNullOrEmpty(newPassword))
            {
                // Trường hợp newPassword là rỗng hoặc null, không cập nhật mật khẩu
                string query = $"UPDATE account SET display_name = '{displayName}' WHERE user_name = '{userName}' and password = '{oldPassword}'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result;
            }
            else
            {
                string query = "UPDATE account SET display_name = @DisplayName , password = @NewPassword WHERE user_name = @userName and password = @oldPassword";

                int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] {displayName, newPassword, userName, oldPassword });
                return result;
            }
        }

        public DataTable GetAllAccount()
        {
            string query = $"select user_name, display_name, user_type from account";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                if (item["user_type"].ToString() == "0")
                {
                    item["user_type"] = "一般ユーザー"; // Gán giá trị mới
                }
                else
                {
                    item["user_type"] = "マネージャー";
                }
            }
            return dt;
        }

        // Insert new account
        public bool InsertNewAccount(string userName, string displayName, string accountType)
        {
            string query = $"insert into account values('{userName}', '{displayName}', '0', '{accountType}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query); 

            return result > 0;
        }

        // Delete account
        public bool DeleteAccountByUserName(string userName)
        {
            string query = $"delete from account where user_name = '{userName}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Update table
        public bool UpdateAccountByUserName(string userName, string displayName, int accountType)
        {
            string query = $"update account set display_name = '{displayName}', user_type = {accountType} where user_name = '{userName}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        // Reset password
        public bool ResetPassword(string userName)
        {
            string query = $"update account set password = 0 where user_name = '{userName}'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
