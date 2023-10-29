using CofffeeStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class FoodCategoryDAO
    {
        private static FoodCategoryDAO instance;

        public static FoodCategoryDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodCategoryDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private FoodCategoryDAO() { }

        public List<KeyValuePair<int, string>> GetListFoodCategory()
        {
            List<KeyValuePair<int, string>> foodCategoryDTOs = new List<KeyValuePair<int, string>>();

            string query = "select * from foodCategory";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                foodCategoryDTOs.Add(new KeyValuePair<int, string>(Convert.ToInt32(item[0]), item[1].ToString()));
            }

            return foodCategoryDTOs;
        }

        // Get all category
        public DataTable GetAllCategory()
        {
            string query = "select * from foodCategory";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        // Insert new category
        public bool InsertCategory(string categoryName)
        {
            string query = $"insert into foodCategory values('{categoryName}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Delete category
        public bool DeleteCategoryById(int categoryId)
        {
            string query = $"delete from foodCategory where id = {categoryId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        // Update category
        public bool UpdateCategoryById(int categoryId, string categoryName)
        {
            string query = $"update foodCategory set category_name = '{categoryName}' where id = {categoryId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
