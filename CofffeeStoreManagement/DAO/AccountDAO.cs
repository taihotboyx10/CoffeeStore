using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
