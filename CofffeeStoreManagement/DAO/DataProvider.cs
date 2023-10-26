using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Common;

namespace CofffeeStoreManagement.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // dong goi:Ctrl + R + E

        public static DataProvider Instance 
        {
            get {
                    if (instance == null) 
                    { 
                        instance = new DataProvider(); 
                    }
                    return DataProvider.instance;
                }
            private set => instance = value; //private chi noi bo class dc sua doi
        }
        private DataProvider() { }

        private SqlConnection Connection()
        {
            string connectionStr = "Data Source=DESKTOP-BV5B025;Initial Catalog=CoffeeManagement;Integrated Security=True;";
            SqlConnection sqlConnect = new SqlConnection(connectionStr);
            return sqlConnect;
        }

        public DataTable ExecuteQuery(string query, object[] param = null) 
        { 
            DataTable dt = new DataTable();
            using (SqlConnection sqlConnection = Connection())
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if(param != null) 
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (string paramStr in listParam)
                    {
                        if (paramStr.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(paramStr, param[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dt);

                sqlConnection.Close();
            }
            return dt;
        }

        public int ExecuteNonQuery(string query, object[] param = null)
        {
            int lineAffectedNum = 0;
            using (SqlConnection sqlConnection = Connection())
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (param != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (string paramStr in listParam)
                    {
                        if (paramStr.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(paramStr, param[i]);
                            i++;
                        }
                    }
                }

                lineAffectedNum = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();
            }
            return lineAffectedNum;
        }

        public object ExecuteScalar(string query, object[] param = null)
        {
            object obj = null;
            using (SqlConnection sqlConnection = Connection())
            {
                sqlConnection.Open();

                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                if (param != null)
                {
                    int i = 0;
                    string[] listParam = query.Split(' ');
                    foreach (string paramStr in listParam)
                    {
                        if (paramStr.Contains('@'))
                        {
                            sqlCommand.Parameters.AddWithValue(paramStr, param[i]);
                            i++;
                        }
                    }
                }

                obj = sqlCommand.ExecuteScalar();

                sqlConnection.Close();
            }
            return obj;
        }
    }
}
