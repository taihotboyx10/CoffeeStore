using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofffeeStoreManagement.DAO
{
    public class ReservationDAO
    {
        
        private static ReservationDAO instance;

        public static ReservationDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReservationDAO();
                }
                return instance;
            }
            private set => instance = value;
        }
        private ReservationDAO() { }

        public DataTable GetAllReservation(DateTime now)
        {
            string query = $"select * from reservation where res_date >= '{now}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        // Insert new cus reservation
        public bool InsertNewCusReser(string cusName, string phone, DateTime date, TimeSpan time, int peopleNum)
        {
            string query = $"insert into reservation (cus_name, phone, res_date, res_time, people_num) " +
                $"values ('{cusName}', '{phone}', '{date}', '{time}', {peopleNum})";

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCusReser(int cusId)
        {
            string query = $"delete from reservation where id = {cusId}";
            int result = DataProvider.Instance.ExecuteNonQuery (query);

            return result > 0;
        }

        public bool UpdateCusReser(int cusId, string cusName, string phone, DateTime date, TimeSpan time, int peopleNum)
        {
            string query = $"update reservation set cus_name = '{cusName}', phone = '{phone}', res_date = '{date}', res_time = '{time}', " +
                $"people_num = {peopleNum} where id = {cusId}";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public DataTable GetReserByDate(DateTime dateTime)
        {
            string query = $"select * from reservation " +
                           $"where res_date = '{dateTime}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable GetReserByDateToDate(DateTime dateTimeFrom, DateTime dateTimeTo)
        {
            string query = $"SELECT * FROM reservation " +
               $"WHERE res_date BETWEEN '{dateTimeFrom}' AND '{dateTimeTo}'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }
    }
    
}
