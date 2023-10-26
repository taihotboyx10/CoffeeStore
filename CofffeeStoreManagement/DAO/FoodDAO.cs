using CofffeeStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class FoodDAO
    {
        private static FoodDAO instance;

        public static FoodDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new FoodDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private FoodDAO() { }

        public FoodDTO GetFoodByFoodId(int foodId)
        {
            FoodDTO foodDTO = new FoodDTO();
            string query = $"select * from food where id = {foodId}";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foodDTO.Id = Convert.ToInt32(dataTable.Rows[0]);
            foodDTO.FoodName = dataTable.Rows[1].ToString();
            foodDTO.IdCategory = Convert.ToInt32(dataTable.Rows[2]);
            foodDTO.Price = Convert.ToDouble(dataTable.Rows[3]);

            return foodDTO;
        }

        public List<FoodDTO> GetListFoodByFoodCategory(int foodCategoryId) 
        { 
            List<FoodDTO> foodLists = new List<FoodDTO>();
            string query = $"select * from food where id_category = {foodCategoryId}";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in dataTable.Rows)
            {
                foodLists.Add(new FoodDTO() 
                { 
                    Id = Convert.ToInt32(item[0]),
                    FoodName = item[1].ToString(),
                    IdCategory = Convert.ToInt32(item[2]),
                    Price = Convert.ToDouble(item[3])
                });
            }

            return foodLists;
        }
    }
}
