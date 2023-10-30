using CofffeeStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;

        public static TableDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TableDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private TableDAO() { }

        public List<TableDTO> GetTableList()
        {
            List<TableDTO> tableDTOs = new List<TableDTO>();

            string query = $"select * from tableSeat";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dt.Rows)
            {
                tableDTOs.Add(new TableDTO
                {
                    Id = Convert.ToInt32(dataRow["id"]),
                    Name = dataRow["table_name"].ToString(),
                    TableStatus = Convert.ToInt32(dataRow["table_status"])
                });
            }

            return tableDTOs;

        }

        public DataTable GetAllTable()
        {

            string query = $"select id, table_name from tableSeat";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            
            return dt;

        }
        public int GetTableStatus(int tableId)
        {
            string query = $"select table_status from tableSeat where id = {tableId}";
            int dt = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query));

            return dt;
        }

        public void TableStatusUpdate(int tableId, int status)
        {
            string query = $"update tableSeat set table_status = {status} where id = {tableId}";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        // ham nay thua, k dng den
        public List<string> GetListTableSeat(int status)
        {
            List<string> listTable = new List<string>();
            string query = $"select table_name from tableSeat where table_status = {status}";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                listTable.Add(item[0].ToString());

            }

            return listTable;
        }

        //Get tableId bay tableName
        public int GetTableIdByTableName(string tableName)
        {
            string query = $"select id from tableSeat where table_name = '{tableName}'";
            int tableId = (int)DataProvider.Instance.ExecuteScalar(query);
            return tableId;
        }

        // Insert new table
        public bool InsertNewTable(string tableNum)
        {
            string query = $"insert into tableSeat values('{tableNum}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Delete table
        public bool DeleteTableById(int tableId)
        {
            string query = $"delete from tableSeat where id = {tableId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Update table
        public bool UpdateTableById(int tableId, string tableNum)
        {
            string query = $"update tableSeat set table_name = '{tableNum}' where id = {tableId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
