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

        // hien tai k dung den ham nay
        public List<string> GetCategoryList()
        {
            List<string> categories = new List<string>();
            string query = "select category_name from foodCategory";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                categories.Add(item[0].ToString());
            }

            return categories;
        }
    }
}
