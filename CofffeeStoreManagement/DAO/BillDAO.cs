using CofffeeStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BillDAO() { }

        // Select bill chua tinh tien theo table(status = 0)
        public int GetUnCheckedBillByTableId(int tableId)
        {

            string query = $"select * from bill where id_tableSeat = {tableId} and status_paid = 0";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            if(dataTable.Rows.Count > 0)
            {
                BillDTO billDTO = new BillDTO();
                billDTO.Id = Convert.ToInt32(dataTable.Rows[0]["id"]);
                return billDTO.Id;
            }
            return -1;
        }

        // Select cac bill da duoc tinh tien(status = 1)
        public DataTable GetBillCashiered()
        {
            string query = "select id, id_table, date_checkin, discount, total_price from bill" +
                           "where status_paid = 1";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        // Select cac bill da duoc tinh tien theo ngay(status = 1)
        public DataTable GetBillCashieredByDate(DateTime dateTime)
        {
            string query = $"select id, id_table, date_checkin, discount, total_price from bill" +
                           $"where status_paid = 1 and date_checkin = {dateTime}";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        // Select cac bill da duoc tinh tien theo ngay(status = 1)
        public DataTable GetBillCashieredByDateToDate(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            string query = $"SELECT id, id_table, date_checkin, discount, total_price FROM bill " +
               $"WHERE status_paid = 1 AND date_checkin BETWEEN '{dateTimeFrom}' AND '{dateTimeTo}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
        //Insert bill moi
        public void InsertBill(int tableId)
        {
            string query = $"insert into bill (id_tableSeat) values ({tableId})";
            DataProvider.Instance.ExecuteNonQuery(query);

        }

        // Update vao bill date_checkout va status_paid
        public void UpdateBillWhenCashier(int billId, double totalPrice, string discount = null)
        {
            string query = $"update bill set date_checkout = '{DateTime.Now}', status_paid = 1, discount = '{discount}', total_price = {totalPrice} where id = {billId}";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        // Update table and bill when change table
        public void UpdateTableIdInBillWhenChangeTable(int newTableId, int oldTableId)
        {
            string query = $"update bill set id_tableSeat = {newTableId} where id_tableSeat = {oldTableId}";
            DataProvider.Instance.ExecuteNonQuery (query);
        }
    }
}
