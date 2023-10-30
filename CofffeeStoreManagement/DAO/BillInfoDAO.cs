using CofffeeStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class BillInfoDAO
    {
        private static BillInfoDAO instance;

        public static BillInfoDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BillInfoDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private BillInfoDAO() { }

        public List<BillInfoDTO> GetListBillInfoByBillId(int billId)
        {
            List<BillInfoDTO> billInfoDTOs = new List<BillInfoDTO>();
            string query = $"select * from billInfo where id_bill = {billId}";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows)
            {
                billInfoDTOs.Add(new BillInfoDTO()
                {
                    Id = Convert.ToInt32(dataRow["id"]),
                    IdBill = Convert.ToInt32(dataRow["id_bill"]),
                    IdFood = Convert.ToInt32(dataRow["id_food"]),
                    FoodCount = Convert.ToInt32(dataRow["food_count"])
                });
            }
            return billInfoDTOs;
        }

        // Insert billInfo moi
        public void InsertBillInfo(int billId, int foodId, int count)
        {
            string query = $"insert into billInfo (id_bill, id_food, food_count) values ({billId},{foodId},{count})";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        // Get list foodId trong billInfo
        public List<int> GetListFoodIdInBillInfo(int billId)
        {
            List<int> listFoodId = new List<int>();
            string query = $"select id_food from billInfo where id_bill = {billId}";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in dataTable.Rows )
            {
                listFoodId.Add(Convert.ToInt32(dataRow[0]));
            }

            return listFoodId;
        }

        public void UpdateMenuDTOForBillInfo(int foodId, int count)
        {
            string query = $"update billInfo set food_count = {count} where id_food = {foodId}";
            DataProvider.Instance.ExecuteNonQuery (query);
        }

        public void DeleteBillInfo(int foodId)
        {
            string query = $"delete from billInfo where id_food = {foodId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool DeleteBillInfoWhenDeleteFood(int foodId)
        {
            string query = $"delete from billInfo where id_food = {foodId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
