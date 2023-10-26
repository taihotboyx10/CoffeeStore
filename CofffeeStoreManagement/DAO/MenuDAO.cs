using CofffeeStoreManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;

        public static MenuDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MenuDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private MenuDAO() { }

        public List<MenuDTO> GetListMenuByTable(int tableId)
        {
            List<MenuDTO> menuDTOs = new List<MenuDTO>();
            string query = $"SELECT food.food_name, food.price, billInfo.food_count, billInfo.food_count * food.price AS total_price " +
               $"FROM food, billInfo, bill " +
               $"WHERE billInfo.id_bill = bill.id AND food.id = billInfo.id_food AND bill.status_paid = 0 AND bill.id_tableSeat = {tableId}";
            
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                MenuDTO menuDTO = new MenuDTO() 
                { 
                    FoodName = item[0].ToString(),
                    Price = Convert.ToDouble(item[1]),
                    Count = Convert.ToInt32(item[2]),
                    TotalPrice = Convert.ToDouble(item[3]),
                };
                menuDTOs.Add(menuDTO);
            }

            return menuDTOs;
        }

        public MenuDTO GetMenuDTOByFoodId(int foodId, int count)
        {
            MenuDTO menuDTO = new MenuDTO();
            string query = $"SELECT food.food_name, food.price, {count}, {count}* food.price AS total_price " +
               $"FROM food WHERE id = {foodId}";

            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                menuDTO.FoodName = item[0].ToString();
                menuDTO.Price = Convert.ToDouble(item[1]);
                menuDTO.Count = Convert.ToInt32(item[2]);
                menuDTO.TotalPrice = Convert.ToDouble(item[3]);
                
            }

            return menuDTO;
        }


    }
}
