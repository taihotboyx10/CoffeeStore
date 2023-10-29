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
        BindingSource foodList = new BindingSource();
        BindingSource categoryList = new BindingSource();
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
            dgvFood.DataSource = foodList;
            LoadFood();
            FoodBinding();

            // dgv category
            dgvCategory.DataSource = categoryList;
            LoadCategory();
            CategoryBinding();
        }

        private void LoadFood()
        {
            // dgv food
            foodList.DataSource = FoodDAO.Instance.GetAllFood();
        }

        /// <summary>
        /// dgvFood binding
        /// </summary>
        private void FoodBinding()
        {
            txtFoodId.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "food_name", true, DataSourceUpdateMode.Never));
            cboCategoryFood.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "category_name", true, DataSourceUpdateMode.Never));
            txtFoodPrice.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "price", true, DataSourceUpdateMode.Never));
        }
        private void LoadCategory()
        {
            // dgv category
            categoryList.DataSource = FoodCategoryDAO.Instance.GetAllCategory();
        }

        /// <summary>
        /// dgvFood binding
        /// </summary>
        private void CategoryBinding()
        {
            txtCategoryId.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "id", true, DataSourceUpdateMode.Never));
            txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "category_name", true, DataSourceUpdateMode.Never));
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
        private bool IsCheckNullInTabFood()
        {
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
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtFoodPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
        private void btnFoodSearch_Click(object sender, EventArgs e)
        {
            int number;
            DataTable dt = new DataTable();
            if (string.IsNullOrEmpty(txtFoodSearch.Text.Trim()))
            {
                return;
            }

            if (int.TryParse(txtFoodSearch.Text, out number))
            {

                // Đây là kiểu int
                foodList.DataSource = FoodDAO.Instance.GetFoodByFilter(number);
            }
            else
            {
                foodList.DataSource = FoodDAO.Instance.GetFoodByFilter(txtFoodSearch.Text);
            }

            dgvFood.DataSource = foodList;

        }

        private void cboCategoryFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryIdWG = Convert.ToInt16(cboCategoryFood.SelectedValue);
        }

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {
            if (!IsCheckNullInTabFood())
            {
                return;
            }
            string foodName = txtFoodName.Text;
            double price = Convert.ToDouble(txtFoodPrice.Text);
            int result = FoodDAO.Instance.InsertNewFood(foodName, categoryIdWG, price);
            if(result > 0)
            {
                MessageUtil.ShowMessage("INF_3002", MessageBoxButtons.OK, this.Text);
                LoadFood();
            }
        }


        private void btnFoodDelete_Click(object sender, EventArgs e)
        {
            if(MessageUtil.ShowMessage("QUES_1006", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                if(FoodDAO.Instance.DeleteFoodByFoodId(Convert.ToInt16(txtFoodId.Text)))
                {
                    MessageUtil.ShowMessage("INF_3004", MessageBoxButtons.OK, this.Text);
                    LoadFood();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFoodId.Text = string.Empty;
            txtFoodName.Text = string.Empty;
            txtFoodPrice.Text = string.Empty;
        }
        

        private void btnFoodUpdate_Click(object sender, EventArgs e)
        {
            if (!IsCheckNullInTabFood())
            {
                return;
            }

            if (MessageUtil.ShowMessage("QUES_1005", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                int foodId = Convert.ToInt16(txtFoodId.Text);
                string foodName = txtFoodName.Text;
                int categoryId = categoryIdWG;
                double price = Convert.ToDouble(txtFoodPrice.Text);
                if (FoodDAO.Instance.UpdateFoodByFoodId(foodId, foodName, categoryId, price))
                {
                    MessageUtil.ShowMessage("INF_3003", MessageBoxButtons.OK, this.Text);
                    LoadFood();
                }
            }
        }

        private void btnFoodView_Click(object sender, EventArgs e)
        {
            LoadFood();
            dgvFood.DataSource = foodList;
        }
        #endregion

        #region Category
        private bool IsCheckNullInTabCategory()
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "カテゴリ名");
                txtCategoryName.Focus();
                return false;
            }
            return true;
        }
        private void btnCategoryAdd_Click(object sender, EventArgs e)
        {
            if (!IsCheckNullInTabCategory())
            {
                return;
            }
            if (FoodCategoryDAO.Instance.InsertCategory(txtCategoryName.Text))
            {
                MessageUtil.ShowMessage("INF_3002", MessageBoxButtons.OK, this.Text);
                LoadCategory();
            }
        }

        private void btnCategoryDelete_Click(object sender, EventArgs e)
        {
            if (MessageUtil.ShowMessage("QUES_1006", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                if (FoodCategoryDAO.Instance.DeleteCategoryById(Convert.ToInt16(txtCategoryId.Text)))
                {
                    MessageUtil.ShowMessage("INF_3004", MessageBoxButtons.OK, this.Text);
                    LoadCategory();
                }
            }
        }
        private void btnCategoryUpdate_Click(object sender, EventArgs e)
        {
            if (!IsCheckNullInTabCategory())
            {
                return;
            }
            if (MessageUtil.ShowMessage("QUES_1005", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                int categoryId = Convert.ToInt16(txtCategoryId.Text);
                string categoryName = txtCategoryName.Text;
                if (FoodCategoryDAO.Instance.UpdateCategoryById(categoryId, categoryName))
                {
                    MessageUtil.ShowMessage("INF_3003", MessageBoxButtons.OK, this.Text);
                    LoadCategory();
                }
            }
        }
        private void btnCategoryView_Click(object sender, EventArgs e)
        {
            LoadCategory();
        }
        #endregion

    }
}
