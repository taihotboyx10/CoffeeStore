using CofffeeStoreManagement.DAO;
using CofffeeStoreManagement.DTO;
using CofffeeStoreManagement.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofffeeStoreManagement
{
    public partial class Main : Form
    {

        double cashierWG;

        private AccountDTO accountDTO;
        //public AccountDTO AccountDTO { get => accountDTO; set => accountDTO = value; }

        public Main(AccountDTO account)
        {
            this.accountDTO = account;
            InitializeComponent();
        }       

        private void Main_Load(object sender, EventArgs e)
        {
            // Message check change password
            if(this.accountDTO.password == "0")
            {
                MessageUtil.ShowMessage("INF_3006", MessageBoxButtons.OK, this.Text);
            }

            ChangeAccount(this.accountDTO.accountType);
            pnlTable.Controls.Clear();
            //Table load
            List<TableDTO> tableDTOs = TableDAO.Instance.GetTableList();
            foreach (TableDTO table in tableDTOs)
            {
                string tsSTR = Constant.TABLE_STATUS[table.TableStatus];

                Button btnTable = new Button();
                //Tao event click cho btnTable
                btnTable.Click += BtnTable_Click; ;
                //Luu table vao tag
                btnTable.Tag = table;

                btnTable.Size = new Size(100,70);
                btnTable.Text = table.Name + Environment.NewLine + $"({tsSTR})";
                if(table.TableStatus == 0)
                {
                    btnTable.BackColor = Color.DeepSkyBlue;
                }
                else if(table.TableStatus == 1)
                {
                    btnTable.BackColor = Color.LightCoral;
                }
                else
                {
                    btnTable.BackColor = Color.OrangeRed;
                }
                pnlTable.Controls.Add(btnTable);
            }

            // Category load
            List<KeyValuePair<int, string>> foodCategoryDTOs = FoodCategoryDAO.Instance.GetListFoodCategory();
            cboCategory.DisplayMember = "Value"; // Hiển thị giá trị của cặp giá trị
            cboCategory.ValueMember = "Key"; // Giữ giá trị của cặp giá trị
            cboCategory.DataSource = new BindingSource(foodCategoryDTOs, null); // Đặt nguồn dữ liệu là danh sách

            // Get cac table dua vao change table
              // Clear truoc khi them de tranh trung lap
            cboTableBase.Items.Clear();
            cboTableDestination.Items.Clear();

            foreach (TableDTO table in tableDTOs)
            {
                if(table.TableStatus == 1)
                {
                    cboTableBase.Items.Add(table.Name);
                }
                else
                {
                    cboTableDestination.Items.Add(table.Name);
                }
            }
        }

        private void ChangeAccount(int type)
        {
            管理者ToolStripMenuItem.Enabled = (type == 1);
        }

        /// <summary>
        /// Thay doi category => thay doi ten mon
        /// </summary>
        private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryId = (int)cboCategory.SelectedValue;
            List<FoodDTO> foodList = FoodDAO.Instance.GetListFoodByFoodCategory(categoryId);
            cboFoodName.DisplayMember = "FoodName";
            cboFoodName.DataSource = foodList;
        }
        
        /// <summary>
        /// event dc sinh ra tu su kien them button table
        /// </summary>
        private void BtnTable_Click(object sender, EventArgs e)
        {
            int tableId = ((sender as Button).Tag as TableDTO).Id;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableId);
            lblTableName.Visible = true;
            lblTableName.Text = ((sender as Button).Tag as TableDTO).Name;
        }

        /// <summary>
        /// Show bill theo table
        /// </summary>
        /// <param name="tableId"></param>
        private void ShowBill(int tableId)
        {

            lsvBill.Items.Clear(); // Xóa tất cả mục trước khi hiển thị dữ liệu mới.
            List<MenuDTO> menuDTOs = MenuDAO.Instance.GetListMenuByTable(tableId);
            foreach (MenuDTO item in menuDTOs)
            {
                ListViewItem listViewItem = new ListViewItem(item.FoodName.ToString());
                listViewItem.SubItems.Add(item.Price.ToString());
                listViewItem.SubItems.Add(item.Count.ToString());
                listViewItem.SubItems.Add(item.TotalPrice.ToString());
                lsvBill.Items.Add(listViewItem);
            }

            TotalPrice(lsvBill);
        }

        /// <summary>
        /// Tinh tong tien theo bill
        /// </summary>
        /// <param name="listView"></param>
        private void TotalPrice(ListView listView)
        {
            double total = 0;
            foreach (ListViewItem item in listView.Items)
            {
                total += Convert.ToDouble(item.SubItems[3].Text);
            }

            cashierWG = total;
            //Chuyen doi don vi 
            CultureInfo culture = new CultureInfo("ja");
            //Thread.CurrentThread.CurrentCulture = culture;
            txtCashier.Text = total.ToString("c", culture);
        }

        /// <summary>
        /// Neu gia tri cua food ma bang 0 hoac be hon 0 thi xoa khoi bill va lsv
        /// </summary>
        /// <param name="listView"></param>
        /// <param name="foodId"></param>
        private void FoodCountReturn(ListView listView, int foodId)
        {
            foreach (ListViewItem item in listView.Items)
            {
                if(Convert.ToInt32(item.SubItems[2].Text) <= 0)
                {
                    //xoa billInfo
                    BillInfoDAO.Instance.DeleteBillInfo(foodId);
                    listView.Items.Remove(item);
                }
            }
        }

        #region Validate
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Từ chối ký tự không phải số và ký tự điều khiển (như Backspace)
            }
        }
        /// <summary>
        /// Check so luong mon an trong numeric truoc khi them
        /// </summary>
        /// <returns></returns>
        private bool CheckFoodCount()
        {
            int foodCount = Convert.ToInt32(nmrFoodNum.Value);
            if(foodCount == 0)
            {
                return false;
            }
            return true;
        }
        #endregion

        private void btnFoodAdd_Click(object sender, EventArgs e)
        {

            // Lấy id table hiện tại đang chọn
            TableDTO table = lsvBill.Tag as TableDTO;
            if (table == null)
            {
                MessageUtil.ShowMessage("ERR_2006", MessageBoxButtons.OK, this.Text);
                return;
            }
            int tableId = table.Id;

            int foodId = (cboFoodName.SelectedItem as FoodDTO).Id;

            int billId = BillDAO.Instance.GetUnCheckedBillByTableId(tableId);

            // Check table status truoc khi them mon
            int status = TableDAO.Instance.GetTableStatus(tableId);
            if(status == 0 && (Convert.ToInt32(nmrFoodNum.Value) > 0)) // TH1: nếu bàn trống insert bill và billInfo
            {
                // insert bill moi cho ban moi
                BillDAO.Instance.InsertBill(tableId);


                //check food count khac 0
                if (!CheckFoodCount())
                {
                    MessageUtil.ShowMessage("ERR_2004", MessageBoxButtons.OK, this.Text);
                    return;
                }
                // insert billInfo moi cho bill moi
                billId = BillDAO.Instance.GetUnCheckedBillByTableId(tableId);
                BillInfoDAO.Instance.InsertBillInfo(billId, foodId, Convert.ToInt32(nmrFoodNum.Value));

                TableDAO.Instance.TableStatusUpdate(tableId, 1);
                Main_Load(this, null);
                ShowBill(tableId);
            }
            else if(status == 1)// TH2: Đã có bill và thêm món mới vào bill insert món mới vào billInFo
            {
                if (!CheckFoodCount())
                {
                    MessageUtil.ShowMessage("ERR_2004", MessageBoxButtons.OK, this.Text);
                    return;
                }

                List<int> listFoodId = BillInfoDAO.Instance.GetListFoodIdInBillInfo(billId);
                if (!listFoodId.Contains(foodId) && (Convert.ToInt32(nmrFoodNum.Value) > 0))// TH2-1: Trong bill chua co mon muon them
                {
                    MenuDTO menuDTO = MenuDAO.Instance.GetMenuDTOByFoodId(foodId, Convert.ToInt32(nmrFoodNum.Value));
                    ListViewItem listViewItem = new ListViewItem(menuDTO.FoodName.ToString());
                    listViewItem.SubItems.Add(menuDTO.Price.ToString());
                    listViewItem.SubItems.Add(menuDTO.Count.ToString());
                    listViewItem.SubItems.Add(menuDTO.TotalPrice.ToString());
                    lsvBill.Items.Add(listViewItem);

                    BillInfoDAO.Instance.InsertBillInfo(billId, foodId, Convert.ToInt32(nmrFoodNum.Value));
                    TotalPrice(lsvBill);
                }
                else //// TH2-2: Trong bill da co mon muon them va chi can them so luong
                {
                    string foodName = (cboFoodName.SelectedItem as FoodDTO).FoodName;
                    foreach (ListViewItem item in lsvBill.Items)
                    {
                        if (item.SubItems[0].Text == foodName)
                        {
                            int currentQuantity = int.Parse(item.SubItems[2].Text);
                            double currentTotal = double.Parse(item.SubItems[3].Text);
                            int newQuantity = currentQuantity + Convert.ToInt32(nmrFoodNum.Value);
                            decimal newTotal = int.Parse(item.SubItems[1].Text) * newQuantity;

                            // Cập nhật số lượng và tổng tiền
                            item.SubItems[2].Text = newQuantity.ToString();
                            item.SubItems[3].Text = newTotal.ToString();
                            BillInfoDAO.Instance.UpdateMenuDTOForBillInfo(foodId, newQuantity);
                        }
                    }
                    FoodCountReturn(lsvBill, foodId);
                    TotalPrice(lsvBill);
                }
            }

        }

        #region Cashier
        /// <summary>
        /// Giam gia
        /// </summary>
        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if(MessageUtil.ShowMessage("QUES_1003", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(txtDiscount.Text))
                {
                    int percent = Convert.ToInt16(txtDiscount.Text);
                    double priceAfterDiscount = cashierWG * (1 - (double)percent / 100);

                    //Chuyen doi don vi 
                    CultureInfo culture = new CultureInfo("ja");
                    //Thread.CurrentThread.CurrentCulture = culture;
                    txtCashier.Text = priceAfterDiscount.ToString("c", culture);

                }
            }
        }

        /// <summary>
        /// Thanh toan
        /// </summary>
        private void btnCashier_Click(object sender, EventArgs e)
        {
            TableDTO tableDTO = lsvBill.Tag as TableDTO;
            if(tableDTO == null)
            {
                return;
            }
            int billId = BillDAO.Instance.GetUnCheckedBillByTableId(tableDTO.Id);
            if(billId != -1)
            {
                DialogResult result = MessageUtil.ShowMessage("QUES_1002", MessageBoxButtons.OKCancel, this.Text);
                if(result == DialogResult.OK)
                {
                    // update table ve trong
                    TableDAO.Instance.TableStatusUpdate(tableDTO.Id, 0);

                    // update bill ve status da thanh toan, date_checkout, discount, totalPrice
                    BillDAO.Instance.UpdateBillWhenCashier(billId, cashierWG, txtDiscount.Text);

                    MessageUtil.ShowMessage("INF_3001", MessageBoxButtons.OK, this.Text);
                    Main_Load(this, null);
                }
            }
            else
            {
                MessageUtil.ShowMessage("ERR_2005", MessageBoxButtons.OK, this.Text);
            }

        }
        #endregion

        #region Table change
        private void btnTableChange_Click(object sender, EventArgs e)
        {
            
            string tableBaseName = cboTableBase.SelectedItem as string;
            string tableDestinationName = cboTableDestination.SelectedItem as string;
            if (tableBaseName != null && tableDestinationName != null)
            {
                
                string message = cboTableBase.Text + "から" + cboTableDestination.Text + "へチェンジします。よろしいですか？";
                if (MessageBox.Show(message, this.Text, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                {
                    return;
                }

                // Update table goc
                int tableBaseId = TableDAO.Instance.GetTableIdByTableName(tableBaseName);
                TableDAO.Instance.TableStatusUpdate(tableBaseId, 0);

                // Update table dich
                int tableDestinationId = TableDAO.Instance.GetTableIdByTableName(tableDestinationName);
                TableDAO.Instance.TableStatusUpdate(tableDestinationId, 1);
                BillDAO.Instance.UpdateTableIdInBillWhenChangeTable(tableDestinationId, tableBaseId);

                // Load lai form
                Main_Load(this, null);
            }
        }

        #endregion

        #region ToolStrip
        private void アカウント情報ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile accountProfile = new AccountProfile(accountDTO);
            accountProfile.ShowDialog();
        }

        private void 管理者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminManagement adminManagement = new AdminManagement();
            adminManagement.loginAccount = this.accountDTO; 
            adminManagement.ShowDialog();
        }
        #endregion

        #region Close
        private void ログアウトToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageUtil.ShowMessage("QUES_1001", MessageBoxButtons.OKCancel, this.Text);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
        #endregion

    }
}
