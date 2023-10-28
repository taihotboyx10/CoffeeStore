namespace CofffeeStoreManagement
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アカウント情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.個人情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ログアウトToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnFoodAdd = new Guna.UI2.WinForms.Guna2Button();
            this.nmrFoodNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboTableBase = new System.Windows.Forms.ComboBox();
            this.cboFoodName = new System.Windows.Forms.ComboBox();
            this.btnCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.txtCashier = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTableName = new System.Windows.Forms.Label();
            this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboTableDestination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodNum)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理者ToolStripMenuItem,
            this.アカウント情報ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(940, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 管理者ToolStripMenuItem
            // 
            this.管理者ToolStripMenuItem.Name = "管理者ToolStripMenuItem";
            this.管理者ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.管理者ToolStripMenuItem.Text = "管理者";
            this.管理者ToolStripMenuItem.Click += new System.EventHandler(this.管理者ToolStripMenuItem_Click);
            // 
            // アカウント情報ToolStripMenuItem
            // 
            this.アカウント情報ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.個人情報ToolStripMenuItem,
            this.ログアウトToolStripMenuItem});
            this.アカウント情報ToolStripMenuItem.Name = "アカウント情報ToolStripMenuItem";
            this.アカウント情報ToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.アカウント情報ToolStripMenuItem.Text = "アカウント情報";
            // 
            // 個人情報ToolStripMenuItem
            // 
            this.個人情報ToolStripMenuItem.Name = "個人情報ToolStripMenuItem";
            this.個人情報ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.個人情報ToolStripMenuItem.Text = "アカウント情報";
            this.個人情報ToolStripMenuItem.Click += new System.EventHandler(this.アカウント情報ToolStripMenuItem_Click);
            // 
            // ログアウトToolStripMenuItem
            // 
            this.ログアウトToolStripMenuItem.Name = "ログアウトToolStripMenuItem";
            this.ログアウトToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.ログアウトToolStripMenuItem.Text = "ログアウト";
            this.ログアウトToolStripMenuItem.Click += new System.EventHandler(this.ログアウトToolStripMenuItem_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.AutoScroll = true;
            this.pnlTable.Location = new System.Drawing.Point(12, 36);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(427, 476);
            this.pnlTable.TabIndex = 1;
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(813, 60);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(119, 25);
            this.cboCategory.TabIndex = 2;
            this.cboCategory.SelectedIndexChanged += new System.EventHandler(this.cboCategory_SelectedIndexChanged);
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.BorderRadius = 15;
            this.btnFoodAdd.BorderThickness = 2;
            this.btnFoodAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodAdd.FillColor = System.Drawing.Color.Orange;
            this.btnFoodAdd.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodAdd.ForeColor = System.Drawing.Color.Black;
            this.btnFoodAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnFoodAdd.Image")));
            this.btnFoodAdd.Location = new System.Drawing.Point(812, 217);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(118, 37);
            this.btnFoodAdd.TabIndex = 3;
            this.btnFoodAdd.Text = "料理追加";
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // nmrFoodNum
            // 
            this.nmrFoodNum.BackColor = System.Drawing.Color.Transparent;
            this.nmrFoodNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmrFoodNum.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrFoodNum.Location = new System.Drawing.Point(813, 167);
            this.nmrFoodNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nmrFoodNum.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmrFoodNum.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nmrFoodNum.Name = "nmrFoodNum";
            this.nmrFoodNum.Size = new System.Drawing.Size(118, 25);
            this.nmrFoodNum.TabIndex = 4;
            this.nmrFoodNum.UpDownButtonFillColor = System.Drawing.Color.Gray;
            // 
            // lsvBill
            // 
            this.lsvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvBill.GridLines = true;
            this.lsvBill.HideSelection = false;
            this.lsvBill.Location = new System.Drawing.Point(461, 60);
            this.lsvBill.MultiSelect = false;
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(343, 352);
            this.lsvBill.TabIndex = 5;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            this.lsvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "料理名";
            this.columnHeader1.Width = 137;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "単価(税込)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "数量";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 65;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "合計";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 65;
            // 
            // cboTableBase
            // 
            this.cboTableBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableBase.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableBase.FormattingEnabled = true;
            this.cboTableBase.Location = new System.Drawing.Point(461, 439);
            this.cboTableBase.Name = "cboTableBase";
            this.cboTableBase.Size = new System.Drawing.Size(72, 25);
            this.cboTableBase.TabIndex = 10;
            // 
            // cboFoodName
            // 
            this.cboFoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodName.FormattingEnabled = true;
            this.cboFoodName.Location = new System.Drawing.Point(813, 114);
            this.cboFoodName.Name = "cboFoodName";
            this.cboFoodName.Size = new System.Drawing.Size(119, 25);
            this.cboFoodName.TabIndex = 12;
            // 
            // btnCashier
            // 
            this.btnCashier.BorderRadius = 15;
            this.btnCashier.BorderThickness = 2;
            this.btnCashier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCashier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCashier.FillColor = System.Drawing.Color.Orange;
            this.btnCashier.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCashier.ForeColor = System.Drawing.Color.Black;
            this.btnCashier.Image = ((System.Drawing.Image)(resources.GetObject("btnCashier.Image")));
            this.btnCashier.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCashier.Location = new System.Drawing.Point(812, 441);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(119, 37);
            this.btnCashier.TabIndex = 13;
            this.btnCashier.Text = "会計";
            this.btnCashier.Click += new System.EventHandler(this.btnCashier_Click);
            // 
            // btnTableChange
            // 
            this.btnTableChange.BorderRadius = 15;
            this.btnTableChange.BorderThickness = 2;
            this.btnTableChange.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTableChange.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTableChange.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTableChange.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTableChange.FillColor = System.Drawing.Color.Orange;
            this.btnTableChange.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableChange.ForeColor = System.Drawing.Color.Black;
            this.btnTableChange.Image = ((System.Drawing.Image)(resources.GetObject("btnTableChange.Image")));
            this.btnTableChange.Location = new System.Drawing.Point(538, 441);
            this.btnTableChange.Name = "btnTableChange";
            this.btnTableChange.Size = new System.Drawing.Size(130, 37);
            this.btnTableChange.TabIndex = 14;
            this.btnTableChange.Text = "テーブル変更";
            this.btnTableChange.Click += new System.EventHandler(this.btnTableChange_Click);
            // 
            // btnDiscount
            // 
            this.btnDiscount.BorderRadius = 15;
            this.btnDiscount.BorderThickness = 2;
            this.btnDiscount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDiscount.FillColor = System.Drawing.Color.Orange;
            this.btnDiscount.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnDiscount.Image = ((System.Drawing.Image)(resources.GetObject("btnDiscount.Image")));
            this.btnDiscount.Location = new System.Drawing.Point(674, 441);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(114, 37);
            this.btnDiscount.TabIndex = 15;
            this.btnDiscount.Text = "割引適用";
            this.btnDiscount.Click += new System.EventHandler(this.btnDiscount_Click);
            // 
            // txtCashier
            // 
            this.txtCashier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCashier.DefaultText = "0";
            this.txtCashier.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCashier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCashier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashier.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCashier.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCashier.ForeColor = System.Drawing.Color.Black;
            this.txtCashier.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCashier.Location = new System.Drawing.Point(813, 487);
            this.txtCashier.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCashier.Name = "txtCashier";
            this.txtCashier.PasswordChar = '\0';
            this.txtCashier.PlaceholderText = "";
            this.txtCashier.ReadOnly = true;
            this.txtCashier.SelectedText = "";
            this.txtCashier.Size = new System.Drawing.Size(118, 25);
            this.txtCashier.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(810, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "料理の種類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(769, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(808, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 19;
            this.label3.Text = "料理名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(808, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "数量";
            // 
            // lblTableName
            // 
            this.lblTableName.AutoSize = true;
            this.lblTableName.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTableName.Location = new System.Drawing.Point(602, 36);
            this.lblTableName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableName.Name = "lblTableName";
            this.lblTableName.Size = new System.Drawing.Size(85, 18);
            this.lblTableName.TabIndex = 21;
            this.lblTableName.Text = "table name";
            this.lblTableName.Visible = false;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiscount.DefaultText = "";
            this.txtDiscount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiscount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiscount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiscount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDiscount.ForeColor = System.Drawing.Color.Black;
            this.txtDiscount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiscount.Location = new System.Drawing.Point(674, 488);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PasswordChar = '\0';
            this.txtDiscount.PlaceholderText = "";
            this.txtDiscount.SelectedText = "";
            this.txtDiscount.Size = new System.Drawing.Size(114, 25);
            this.txtDiscount.TabIndex = 22;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // cboTableDestination
            // 
            this.cboTableDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTableDestination.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableDestination.FormattingEnabled = true;
            this.cboTableDestination.Location = new System.Drawing.Point(461, 488);
            this.cboTableDestination.Name = "cboTableDestination";
            this.cboTableDestination.Size = new System.Drawing.Size(72, 25);
            this.cboTableDestination.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(458, 418);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "テーブル元";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(458, 468);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Meiryo UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(458, 468);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "テーブル先";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(940, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnTableChange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboTableDestination);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblTableName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmrFoodNum);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.cboFoodName);
            this.Controls.Add(this.txtCashier);
            this.Controls.Add(this.btnFoodAdd);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.cboTableBase);
            this.Controls.Add(this.lsvBill);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "コーヒーストア管理";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アカウント情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 個人情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ログアウトToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel pnlTable;
        private System.Windows.Forms.ComboBox cboCategory;
        private Guna.UI2.WinForms.Guna2Button btnFoodAdd;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmrFoodNum;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.ComboBox cboTableBase;
        private System.Windows.Forms.ComboBox cboFoodName;
        private Guna.UI2.WinForms.Guna2Button btnCashier;
        private Guna.UI2.WinForms.Guna2Button btnTableChange;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private Guna.UI2.WinForms.Guna2TextBox txtCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTableName;
        private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
        private System.Windows.Forms.ComboBox cboTableDestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}