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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.管理者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アカウント情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.個人情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ログアウトToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTable = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnFoodAdd = new Guna.UI2.WinForms.Guna2Button();
            this.nmrFoodNum = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cboTableChange = new System.Windows.Forms.ComboBox();
            this.nmrDiscount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cboFoodName = new System.Windows.Forms.ComboBox();
            this.btnCashier = new Guna.UI2.WinForms.Guna2Button();
            this.btnTableChange = new Guna.UI2.WinForms.Guna2Button();
            this.btnDiscount = new Guna.UI2.WinForms.Guna2Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理者ToolStripMenuItem,
            this.アカウント情報ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
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
            this.pnlTable.Location = new System.Drawing.Point(12, 36);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(427, 476);
            this.pnlTable.TabIndex = 1;
            // 
            // cboCategory
            // 
            this.cboCategory.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(461, 36);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(199, 25);
            this.cboCategory.TabIndex = 2;
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.BorderRadius = 20;
            this.btnFoodAdd.BorderThickness = 2;
            this.btnFoodAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFoodAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFoodAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFoodAdd.FillColor = System.Drawing.Color.Orange;
            this.btnFoodAdd.Font = new System.Drawing.Font("Meiryo UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoodAdd.ForeColor = System.Drawing.Color.Black;
            this.btnFoodAdd.Location = new System.Drawing.Point(666, 36);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(100, 58);
            this.btnFoodAdd.TabIndex = 3;
            this.btnFoodAdd.Text = "料理追加";
            // 
            // nmrFoodNum
            // 
            this.nmrFoodNum.BackColor = System.Drawing.Color.Transparent;
            this.nmrFoodNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmrFoodNum.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrFoodNum.Location = new System.Drawing.Point(772, 54);
            this.nmrFoodNum.Name = "nmrFoodNum";
            this.nmrFoodNum.Size = new System.Drawing.Size(100, 25);
            this.nmrFoodNum.TabIndex = 4;
            this.nmrFoodNum.UpDownButtonFillColor = System.Drawing.Color.Gray;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(461, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(411, 289);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // cboTableChange
            // 
            this.cboTableChange.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTableChange.FormattingEnabled = true;
            this.cboTableChange.Location = new System.Drawing.Point(461, 487);
            this.cboTableChange.Name = "cboTableChange";
            this.cboTableChange.Size = new System.Drawing.Size(120, 25);
            this.cboTableChange.TabIndex = 10;
            // 
            // nmrDiscount
            // 
            this.nmrDiscount.BackColor = System.Drawing.Color.Transparent;
            this.nmrDiscount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmrDiscount.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDiscount.Location = new System.Drawing.Point(633, 487);
            this.nmrDiscount.Name = "nmrDiscount";
            this.nmrDiscount.Size = new System.Drawing.Size(100, 25);
            this.nmrDiscount.TabIndex = 11;
            this.nmrDiscount.UpDownButtonFillColor = System.Drawing.Color.Gray;
            // 
            // cboFoodName
            // 
            this.cboFoodName.Font = new System.Drawing.Font("Meiryo UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFoodName.FormattingEnabled = true;
            this.cboFoodName.Location = new System.Drawing.Point(461, 69);
            this.cboFoodName.Name = "cboFoodName";
            this.cboFoodName.Size = new System.Drawing.Size(199, 25);
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
            this.btnCashier.Location = new System.Drawing.Point(772, 475);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(100, 37);
            this.btnCashier.TabIndex = 13;
            this.btnCashier.Text = "会計";
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
            this.btnTableChange.Location = new System.Drawing.Point(461, 441);
            this.btnTableChange.Name = "btnTableChange";
            this.btnTableChange.Size = new System.Drawing.Size(120, 37);
            this.btnTableChange.TabIndex = 14;
            this.btnTableChange.Text = "テーブル変更";
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
            this.btnDiscount.Location = new System.Drawing.Point(633, 441);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(100, 37);
            this.btnDiscount.TabIndex = 15;
            this.btnDiscount.Text = "割引";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(884, 524);
            this.Controls.Add(this.btnDiscount);
            this.Controls.Add(this.btnTableChange);
            this.Controls.Add(this.btnCashier);
            this.Controls.Add(this.cboFoodName);
            this.Controls.Add(this.nmrDiscount);
            this.Controls.Add(this.cboTableChange);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nmrFoodNum);
            this.Controls.Add(this.btnFoodAdd);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "コーヒーストア管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrFoodNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDiscount)).EndInit();
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox cboTableChange;
        private Guna.UI2.WinForms.Guna2NumericUpDown nmrDiscount;
        private System.Windows.Forms.ComboBox cboFoodName;
        private Guna.UI2.WinForms.Guna2Button btnCashier;
        private Guna.UI2.WinForms.Guna2Button btnTableChange;
        private Guna.UI2.WinForms.Guna2Button btnDiscount;
    }
}