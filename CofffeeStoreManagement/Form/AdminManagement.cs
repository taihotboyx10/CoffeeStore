using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CofffeeStoreManagement.DAO;
using Microsoft.SqlServer.Server;

namespace CofffeeStoreManagement
{
    public partial class AdminManagement : Form
    {
        //DataProvider sqlConect = new DataProvider();
        string query;

        public AdminManagement()
        {
            InitializeComponent();
            
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            query = "EXEC dbo.Usp_GetAccountByUserNAme @user_name";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] {"taind"});
            dgvAccount.DataSource = dt;

        }
    }
}
