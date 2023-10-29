using CofffeeStoreManagement.DTO;
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
    }
}
