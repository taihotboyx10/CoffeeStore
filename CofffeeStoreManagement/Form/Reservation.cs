using CofffeeStoreManagement.DAO;
using CofffeeStoreManagement.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CofffeeStoreManagement
{
    public partial class 予約リスト : Form
    {

        int hourTemp;
        int minuteTemp;

        BindingSource ReservationList = new BindingSource();

        public 予約リスト()
        {
            InitializeComponent();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {
            // Set value to dtp
            dtpFilterByDate.Value = DateTime.Now;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now.AddMonths(2);

            dgvReservation.DataSource = ReservationList;
            LoadReservation();
            BidingReservation();
        }

        private void LoadReservation()
        {
            ReservationList.DataSource = ReservationDAO.Instance.GetAllReservation(DateTime.Now);
        }

        private void BidingReservation()
        {
            
            txtCusName.DataBindings.Add(new Binding("Text", dgvReservation.DataSource, "cus_name", true, DataSourceUpdateMode.Never));
            txtPhone.DataBindings.Add(new Binding("Text", dgvReservation.DataSource, "phone", true, DataSourceUpdateMode.Never));
            dtpDate.DataBindings.Add(new Binding("Value", dgvReservation.DataSource, "res_date", true, DataSourceUpdateMode.Never));
            txtPeopleNum.DataBindings.Add(new Binding("Text", dgvReservation.DataSource, "people_num", true, DataSourceUpdateMode.Never));

            //Binding cho giờ
            Binding hourBinding = new Binding("Value", dgvReservation.DataSource, "res_time");
            hourBinding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
            hourBinding.Format += (sender, e) =>
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    TimeSpan time = (TimeSpan)e.Value;
                    e.Value = time.Hours;
                }
            };
            hourBinding.Parse += (sender, e) =>
            {
                if (e.Value != null)
                {
                    int hours = Convert.ToInt16(e.Value);
                    if (hours < 0) hours = 0;
                    if (hours > 23) hours = 23;
                    e.Value = new TimeSpan(hours, minuteTemp, 0);
                }
            };
            nmrHour.DataBindings.Add(hourBinding);
            //nmrHour.Value = hourTemp;

            //Binding cho phút
            Binding minuteBinding = new Binding("Value", dgvReservation.DataSource, "res_time");
            minuteBinding.DataSourceUpdateMode = DataSourceUpdateMode.Never;
            minuteBinding.Format += (sender, e) =>
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                    TimeSpan time = (TimeSpan)e.Value;
                    e.Value = time.Minutes;
                }
            };
            minuteBinding.Parse += (sender, e) =>
            {
                if (e.Value != null)
                {
                    int minutes = Convert.ToInt16(e.Value);
                    if (minutes < 0) minutes = 0;
                    if (minutes > 59) minutes = 59;
                    e.Value = new TimeSpan(hourTemp, minutes, 0);
                }
            };
            nmrMinute.DataBindings.Add(minuteBinding);

        }

        #region Validate
        private bool IsCheckNull()
        {
            if (string.IsNullOrEmpty(txtCusName.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "お客様の名前");
                txtCusName.Focus();
                return false;
            }

            Validate validate = new Validate();
            if (string.IsNullOrEmpty(txtPhone.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "電話番号");
                txtPhone.Focus();
                return false;
            }
            else
            {
                if (!validate.PhoneValid(txtPhone.Text))
                {
                    MessageUtil.ShowMessage("ERR_2015", MessageBoxButtons.OK, this.Text, "電話番号");
                    txtPhone.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtPeopleNum.Text))
            {
                MessageUtil.ShowMessage("ERR_2007", MessageBoxButtons.OK, this.Text, "人数");
                txtPeopleNum.Focus();
                return false;
            }

            return true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCusName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            nmrHour.Value = 0;
            nmrMinute.Value = 0;
            txtPeopleNum.Text = string.Empty;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtPeopleNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == '\b'))
            {
                e.Handled = true;
            }
        }

        #endregion

        #region Event
        private void nmrHour_ValueChanged(object sender, EventArgs e)
        {
            hourTemp = Convert.ToInt16(nmrHour.Value);
        }

        private void nmrMinute_ValueChanged(object sender, EventArgs e)
        {
            minuteTemp = Convert.ToInt16(nmrMinute.Value);
        }
        #endregion

        #region CRUD Reservation
        private bool CheckResDate(DateTime resDate)
        {
            // Phai chon ngay tu ngay hom nay tro di
            if(resDate.Date < DateTime.Now.Date)
            {
                MessageUtil.ShowMessage("ERR_2016", MessageBoxButtons.OK, this.Text);
                return false;
            }

            // Chi duoc yoyaku trong vong 2 thang do lai
            if(resDate.Date > DateTime.Now.AddMonths(2))
            {
                MessageUtil.ShowMessage("ERR_2017", MessageBoxButtons.OK, this.Text);
                return false;
            }

            return true;
        }
        private void btnCusAdd_Click(object sender, EventArgs e)
        {
            if (!IsCheckNull())
            {
                return;
            }

            DateTime date = dtpDate.Value;
            if (!CheckResDate(date))
            {
                return;
            }

            string cusName = txtCusName.Text;
            string phone = txtPhone.Text;
            TimeSpan time = new TimeSpan(Convert.ToInt16(nmrHour.Value), Convert.ToInt16(nmrMinute.Value), 0);
            int peopleNum = Convert.ToInt16(txtPeopleNum.Text);

            if (ReservationDAO.Instance.InsertNewCusReser(cusName, phone, date, time, peopleNum))
            {
                MessageUtil.ShowMessage("INF_3002", MessageBoxButtons.OK, this.Text);
                LoadReservation();
            }
        }

        private int GetCusId()
        {
            int cusId = 0; // Khởi tạo giá trị mặc định

            if (dgvReservation.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvReservation.SelectedRows[0]; // Lấy dòng đã chọn
                                                                              // Kiểm tra xem cột "id" có tồn tại và không rỗng
                cusId = Convert.ToInt32(selectedRow.Cells["id"].Value); // Lấy giá trị của cột "id"
            }

            return cusId;
        }
        private void btnCusDelete_Click(object sender, EventArgs e)
        {
            if (MessageUtil.ShowMessage("QUES_1006", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                int cusId = GetCusId();

                if (ReservationDAO.Instance.DeleteCusReser(cusId))
                {
                    MessageUtil.ShowMessage("INF_3004", MessageBoxButtons.OK, this.Text);
                    LoadReservation();
                }
            }
        }

        private void btnCusUpdate_Click(object sender, EventArgs e)
        {
            if (!IsCheckNull())
            {
                return;
            }

            DateTime date = dtpDate.Value;
            if (!CheckResDate(date))
            {
                return;
            }
            if (MessageUtil.ShowMessage("QUES_1005", MessageBoxButtons.OKCancel, this.Text) == DialogResult.OK)
            {
                int cusId = GetCusId();
                string cusName = txtCusName.Text;
                string phone = txtPhone.Text;
                TimeSpan time = new TimeSpan(Convert.ToInt16(nmrHour.Value), Convert.ToInt16(nmrMinute.Value), 0);
                int peopleNum = Convert.ToInt16(txtPeopleNum.Text);

                if (ReservationDAO.Instance.UpdateCusReser(cusId, cusName, phone, date, time, peopleNum))
                {
                    MessageUtil.ShowMessage("INF_3003", MessageBoxButtons.OK, this.Text);
                    LoadReservation();
                }
            }
        }

        private void btnCusView_Click(object sender, EventArgs e)
        {
            LoadReservation();
        }
        #endregion

        private void btnFilterByDate_Click(object sender, EventArgs e)
        {
            ReservationList.DataSource = ReservationDAO.Instance.GetReserByDate(dtpFilterByDate.Value);

        }

        private void btnFilterByDateToDate_Click(object sender, EventArgs e)
        {
            ReservationList.DataSource = ReservationDAO.Instance.GetReserByDateToDate(dtpFrom.Value, dtpTo.Value);
        }

        private void dgvReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvReservation.Columns[e.ColumnIndex].Name == "resTime" && e.RowIndex >= 0)
            {
                if (dgvReservation.Rows[e.RowIndex].Cells["resTime"].Value is TimeSpan timeValue &&
                    dgvReservation.Rows[e.RowIndex].Cells["resDate"].Value is DateTime resDate)
                {
                    DateTime currentDate = resDate.Date; // Lấy ngày từ cột resDate

                    DateTime reservationTime = currentDate.Add(timeValue);

                    // Tính thời gian còn lại đến dự kiến (15 phút)
                    TimeSpan remainingTime = reservationTime - DateTime.Now;

                    if (remainingTime.TotalMinutes >= 0 && remainingTime.TotalMinutes <= 15)
                    {
                        // Đặt màu nền của cột thành màu vàng
                        dgvReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }

                    if (remainingTime.TotalMinutes >= 0 && remainingTime.TotalMinutes <= 15)
                    {
                        // Đặt màu nền của cột thành màu vàng
                        dgvReservation.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    }
                }
            }
        }
    }
}
