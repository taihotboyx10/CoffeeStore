using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CofffeeStoreManagement.DAO;
using CofffeeStoreManagement.Util;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace CofffeeStoreManagement
{
    public partial class AdminManagement : Form
    {
        int categoryIdWG;
        public AdminManagement()
        {
            InitializeComponent();
            
        }

        private void AdminManagement_Load(object sender, EventArgs e)
        {
            // Set data for cboCategory
            List<KeyValuePair<int, string>> categories = FoodCategoryDAO.Instance.GetListFoodCategory();
            cboCategoryFood.DisplayMember = "value";
            cboCategoryFood.ValueMember = "key";
            cboCategoryFood.DataSource = new BindingSource(categories, null);

            // Set value to dtp
            dtpDate.Value = DateTime.Now;
            dtpFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpTo.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

            // dgv bill
            DataTable dtBill = BillDAO.Instance.GetBillCashiered();
            dgvEarning.DataSource = dtBill;

            // dgv food
            DataTable dtFood = FoodDAO.Instance.GetAllFood();
            dgvFood.DataSource = dtFood;


        }

        #region Uriage
        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            DataTable dt = BillDAO.Instance.GetBillCashieredByDate(dtpDate.Value);
            dgvEarning.DataSource = dt;
        }

        private void btnFilterByDateToDate_Click(object sender, EventArgs e)
        {
            DataTable dt = BillDAO.Instance.GetBillCashieredByDateToDate(dtpFrom.Value, dtpTo.Value);
            dgvEarning.DataSource = dt;
        }
        #endregion

        #region Food
        private bool IsCheckNull()
        {
            if (string.IsNullOrEmpty(txtFoodId.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "料理番号");
                txtFoodId.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtFoodName.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "料理名");
                txtFoodName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboCategoryFood.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "カテゴリ名");
                cboCategoryFood.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtFoodPrice.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "単価(税込)");
                txtFoodPrice.Focus();
                return false;
            }

            return true;
        }

        private void txtFoodId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtFoodPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
        private void btnFoodSearch_Click(object sender, EventArgs e)
        {
            int number;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(txtFoodSearch.Text))
            {
                return;
            }

            if (int.TryParse(txtFoodSearch.Text, out number))
            {
                // Đây là kiểu int
                dt = FoodDAO.Instance.GetFoodByFilter(number);
            }
            else
            {
                dt = FoodDAO.Instance.GetFoodByFilter(txtFoodSearch.Text);
            }

            dgvFood.DataSource = dt;
        }

        private void cboCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryIdWG = (int)cboCategoryFood.SelectedValue;
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            if (!IsCheckNull())
            {
                return;
            }
            int foodId = Convert.ToInt16(txtFoodId.Text);
            string foodName = txtFoodName.Text;
            double price = Convert.ToDouble(txtFoodPrice.Text);
            int result = FoodDAO.Instance.InsertNewFood(foodId, foodName, categoryIdWG, price);
            if(result > 0)
            {
                MessageUtil.ShowMessage("INF_3002", MessageBoxButtons.OK, this.Text);
            }
        }


        private void dgvFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFood.SelectedRows.Count > 0)
            {
                int cln = dgvFood.ColumnCount;
                DataGridViewRow selectedRow = dgvFood.SelectedRows[0];
                // Lấy giá trị của cột đầu tiên (có chỉ số là 0)
                for (int i = 0; i < cln; i++)
                {
                    txtFoodId = selectedRow.Cells[0].Value
                }
                object cellValue = selectedRow.Cells[0].Value;
            }
                
        }
        #endregion

    }
}
