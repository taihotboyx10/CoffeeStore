namespace CofffeeStoreManagement
{
    partial class 予約リスト
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(予約リスト));
            this.dgvReservation = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCusAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnCusDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCusUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCusView = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPeopleNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrMinute = new System.Windows.Forms.NumericUpDown();
            this.nmrHour = new System.Windows.Forms.NumericUpDown();
            this.btnFilterByDate = new Guna.UI2.WinForms.Guna2Button();
            this.dtpFilterByDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnFilterByDateToDate = new Guna.UI2.WinForms.Guna2Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReservation
            // 
            this.dgvReservation.AllowUserToAddRows = false;
            this.dgvReservation.AllowUserToResizeRows = false;
            this.dgvReservation.BackgroundColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservation.ColumnHeadersHeight = 30;
            this.dgvReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.resDate,
            this.resTime,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservation.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservation.EnableHeadersVisualStyles = false;
            this.dgvReservation.Location = new System.Drawing.Point(20, 127);
            this.dgvReservation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvReservation.MultiSelect = false;
            this.dgvReservation.Name = "dgvReservation";
            this.dgvReservation.ReadOnly = true;
            this.dgvReservation.RowHeadersVisible = false;
            this.dgvReservation.RowHeadersWidth = 51;
            this.dgvReservation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservation.Size = new System.Drawing.Size(725, 441);
            this.dgvReservation.TabIndex = 27;
            this.dgvReservation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvReservation_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "予約番号";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Width = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cus_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "お客様の名前";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn2.HeaderText = "電話番号";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn2.Width = 90;
            // 
            // resDate
            // 
            this.resDate.DataPropertyName = "res_date";
            this.resDate.HeaderText = "予約日";
            this.resDate.MinimumWidth = 6;
            this.resDate.Name = "resDate";
            this.resDate.ReadOnly = true;
            this.resDate.Width = 125;
            // 
            // resTime
            // 
            this.resTime.DataPropertyName = "res_time";
            this.resTime.HeaderText = "時間帯";
            this.resTime.MinimumWidth = 6;
            this.resTime.Name = "resTime";
            this.resTime.ReadOnly = true;
            this.resTime.Width = 90;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "people_num";
            this.dataGridViewTextBoxColumn4.HeaderText = "人数";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn4.Width = 51;
            // 
            // btnCusAdd
            // 
            this.btnCusAdd.BorderRadius = 15;
            this.btnCusAdd.BorderThickness = 2;
            this.btnCusAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusAdd.FillColor = System.Drawing.Color.Orange;
            this.btnCusAdd.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusAdd.ForeColor = System.Drawing.Color.Black;
            this.btnCusAdd.Location = new System.Drawing.Point(20, 44);
            this.btnCusAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCusAdd.Name = "btnCusAdd";
            this.btnCusAdd.Size = new System.Drawing.Size(115, 43);
            this.btnCusAdd.TabIndex = 31;
            this.btnCusAdd.Text = "追加";
            this.btnCusAdd.Click += new System.EventHandler(this.btnCusAdd_Click);
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.BorderRadius = 15;
            this.btnCusDelete.BorderThickness = 2;
            this.btnCusDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusDelete.FillColor = System.Drawing.Color.Orange;
            this.btnCusDelete.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusDelete.ForeColor = System.Drawing.Color.Black;
            this.btnCusDelete.Location = new System.Drawing.Point(142, 44);
            this.btnCusDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(115, 43);
            this.btnCusDelete.TabIndex = 30;
            this.btnCusDelete.Text = "削除";
            this.btnCusDelete.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // btnCusUpdate
            // 
            this.btnCusUpdate.BorderRadius = 15;
            this.btnCusUpdate.BorderThickness = 2;
            this.btnCusUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusUpdate.FillColor = System.Drawing.Color.Orange;
            this.btnCusUpdate.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnCusUpdate.Location = new System.Drawing.Point(265, 44);
            this.btnCusUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCusUpdate.Name = "btnCusUpdate";
            this.btnCusUpdate.Size = new System.Drawing.Size(115, 43);
            this.btnCusUpdate.TabIndex = 29;
            this.btnCusUpdate.Text = "更新";
            this.btnCusUpdate.Click += new System.EventHandler(this.btnCusUpdate_Click);
            // 
            // btnCusView
            // 
            this.btnCusView.BorderRadius = 15;
            this.btnCusView.BorderThickness = 2;
            this.btnCusView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusView.FillColor = System.Drawing.Color.Orange;
            this.btnCusView.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCusView.ForeColor = System.Drawing.Color.Black;
            this.btnCusView.Location = new System.Drawing.Point(388, 44);
            this.btnCusView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCusView.Name = "btnCusView";
            this.btnCusView.Size = new System.Drawing.Size(115, 43);
            this.btnCusView.TabIndex = 28;
            this.btnCusView.Text = "閲覧";
            this.btnCusView.Click += new System.EventHandler(this.btnCusView_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = true;
            this.dtpDate.CustomFormat = "yyyy/MM/dd";
            this.dtpDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dtpDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDate.ForeColor = System.Drawing.Color.White;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDate.Location = new System.Drawing.Point(142, 28);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(218, 30);
            this.dtpDate.TabIndex = 32;
            this.dtpDate.Value = new System.DateTime(2023, 10, 20, 15, 29, 13, 348);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 15;
            this.btnClear.BorderThickness = 2;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.Orange;
            this.btnClear.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(1033, 525);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(128, 43);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "クリア";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtCusName
            // 
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.ForeColor = System.Drawing.Color.Black;
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Location = new System.Drawing.Point(936, 211);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderText = "";
            this.txtCusName.SelectedText = "";
            this.txtCusName.Size = new System.Drawing.Size(225, 35);
            this.txtCusName.TabIndex = 36;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(790, 211);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 46;
            this.label15.Text = "お客様の名前";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(838, 475);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 22);
            this.label18.TabIndex = 45;
            this.label18.Text = "※";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(876, 279);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 22);
            this.label16.TabIndex = 43;
            this.label16.Text = "※";
            // 
            // txtPhone
            // 
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.DefaultText = "";
            this.txtPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.ForeColor = System.Drawing.Color.Black;
            this.txtPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone.Location = new System.Drawing.Point(936, 271);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.PlaceholderText = "";
            this.txtPhone.SelectedText = "";
            this.txtPhone.Size = new System.Drawing.Size(226, 35);
            this.txtPhone.TabIndex = 37;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtPeopleNum
            // 
            this.txtPeopleNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPeopleNum.DefaultText = "";
            this.txtPeopleNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPeopleNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPeopleNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeopleNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPeopleNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeopleNum.Font = new System.Drawing.Font("Meiryo UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeopleNum.ForeColor = System.Drawing.Color.Black;
            this.txtPeopleNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPeopleNum.Location = new System.Drawing.Point(936, 469);
            this.txtPeopleNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeopleNum.Name = "txtPeopleNum";
            this.txtPeopleNum.PasswordChar = '\0';
            this.txtPeopleNum.PlaceholderText = "";
            this.txtPeopleNum.SelectedText = "";
            this.txtPeopleNum.Size = new System.Drawing.Size(225, 35);
            this.txtPeopleNum.TabIndex = 38;
            this.txtPeopleNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleNum_KeyPress);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "電話番号";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "予約日";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, 475);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "人数";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nmrMinute);
            this.groupBox1.Controls.Add(this.nmrHour);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(794, 314);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 147);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "予約時間";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 42;
            this.label5.Text = "分";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "時間";
            // 
            // nmrMinute
            // 
            this.nmrMinute.Location = new System.Drawing.Point(142, 107);
            this.nmrMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmrMinute.Name = "nmrMinute";
            this.nmrMinute.Size = new System.Drawing.Size(219, 29);
            this.nmrMinute.TabIndex = 34;
            this.nmrMinute.ValueChanged += new System.EventHandler(this.nmrMinute_ValueChanged);
            // 
            // nmrHour
            // 
            this.nmrHour.Location = new System.Drawing.Point(141, 68);
            this.nmrHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nmrHour.Name = "nmrHour";
            this.nmrHour.Size = new System.Drawing.Size(219, 29);
            this.nmrHour.TabIndex = 33;
            this.nmrHour.ValueChanged += new System.EventHandler(this.nmrHour_ValueChanged);
            // 
            // btnFilterByDate
            // 
            this.btnFilterByDate.BorderRadius = 15;
            this.btnFilterByDate.BorderThickness = 2;
            this.btnFilterByDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilterByDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilterByDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilterByDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilterByDate.FillColor = System.Drawing.Color.Orange;
            this.btnFilterByDate.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByDate.ForeColor = System.Drawing.Color.Black;
            this.btnFilterByDate.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterByDate.Image")));
            this.btnFilterByDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilterByDate.Location = new System.Drawing.Point(1039, 110);
            this.btnFilterByDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterByDate.Name = "btnFilterByDate";
            this.btnFilterByDate.Size = new System.Drawing.Size(123, 43);
            this.btnFilterByDate.TabIndex = 47;
            this.btnFilterByDate.Text = "フィルタ";
            this.btnFilterByDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilterByDate.Click += new System.EventHandler(this.btnFilterByDate_Click);
            // 
            // dtpFilterByDate
            // 
            this.dtpFilterByDate.Checked = true;
            this.dtpFilterByDate.CustomFormat = "yyyy/MM/dd";
            this.dtpFilterByDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dtpFilterByDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFilterByDate.ForeColor = System.Drawing.Color.White;
            this.dtpFilterByDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFilterByDate.Location = new System.Drawing.Point(794, 110);
            this.dtpFilterByDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFilterByDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFilterByDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFilterByDate.Name = "dtpFilterByDate";
            this.dtpFilterByDate.Size = new System.Drawing.Size(195, 43);
            this.dtpFilterByDate.TabIndex = 46;
            this.dtpFilterByDate.Value = new System.DateTime(2023, 11, 4, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Checked = true;
            this.dtpTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dtpTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTo.ForeColor = System.Drawing.SystemColors.Window;
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTo.Location = new System.Drawing.Point(794, 44);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(195, 43);
            this.dtpTo.TabIndex = 45;
            this.dtpTo.Value = new System.DateTime(2023, 10, 20, 15, 29, 13, 348);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Checked = true;
            this.dtpFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dtpFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFrom.ForeColor = System.Drawing.Color.White;
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFrom.Location = new System.Drawing.Point(550, 44);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(195, 43);
            this.dtpFrom.TabIndex = 44;
            this.dtpFrom.Value = new System.DateTime(2023, 10, 20, 15, 29, 13, 348);
            // 
            // btnFilterByDateToDate
            // 
            this.btnFilterByDateToDate.BorderRadius = 15;
            this.btnFilterByDateToDate.BorderThickness = 2;
            this.btnFilterByDateToDate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFilterByDateToDate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFilterByDateToDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFilterByDateToDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFilterByDateToDate.FillColor = System.Drawing.Color.Orange;
            this.btnFilterByDateToDate.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterByDateToDate.ForeColor = System.Drawing.Color.Black;
            this.btnFilterByDateToDate.Image = ((System.Drawing.Image)(resources.GetObject("btnFilterByDateToDate.Image")));
            this.btnFilterByDateToDate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilterByDateToDate.Location = new System.Drawing.Point(1039, 44);
            this.btnFilterByDateToDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFilterByDateToDate.Name = "btnFilterByDateToDate";
            this.btnFilterByDateToDate.Size = new System.Drawing.Size(122, 43);
            this.btnFilterByDateToDate.TabIndex = 43;
            this.btnFilterByDateToDate.Text = "フィルタ";
            this.btnFilterByDateToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnFilterByDateToDate.Click += new System.EventHandler(this.btnFilterByDateToDate_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(995, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 22);
            this.label14.TabIndex = 50;
            this.label14.Text = "まで";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(752, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 22);
            this.label13.TabIndex = 49;
            this.label13.Text = "から";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(903, 211);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 22);
            this.label6.TabIndex = 51;
            this.label6.Text = "※";
            // 
            // 予約リスト
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 605);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnFilterByDate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtpFilterByDate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.btnFilterByDateToDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPeopleNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCusAdd);
            this.Controls.Add(this.btnCusDelete);
            this.Controls.Add(this.btnCusUpdate);
            this.Controls.Add(this.btnCusView);
            this.Controls.Add(this.dgvReservation);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "予約リスト";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.Reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservation)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmrMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReservation;
        private Guna.UI2.WinForms.Guna2Button btnCusAdd;
        private Guna.UI2.WinForms.Guna2Button btnCusDelete;
        private Guna.UI2.WinForms.Guna2Button btnCusUpdate;
        private Guna.UI2.WinForms.Guna2Button btnCusView;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDate;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtPeopleNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nmrHour;
        private System.Windows.Forms.NumericUpDown nmrMinute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnFilterByDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFilterByDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private Guna.UI2.WinForms.Guna2Button btnFilterByDateToDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn resDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn resTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}