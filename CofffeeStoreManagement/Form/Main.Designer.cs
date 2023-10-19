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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.管理者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.アカウント情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.個人情報ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ログアウトToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理者ToolStripMenuItem,
            this.アカウント情報ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 48);
            // 
            // 管理者ToolStripMenuItem
            // 
            this.管理者ToolStripMenuItem.Name = "管理者ToolStripMenuItem";
            this.管理者ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.管理者ToolStripMenuItem.Text = "管理者";
            // 
            // アカウント情報ToolStripMenuItem
            // 
            this.アカウント情報ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.個人情報ToolStripMenuItem,
            this.ログアウトToolStripMenuItem});
            this.アカウント情報ToolStripMenuItem.Name = "アカウント情報ToolStripMenuItem";
            this.アカウント情報ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.アカウント情報ToolStripMenuItem.Text = "アカウント情報";
            // 
            // 個人情報ToolStripMenuItem
            // 
            this.個人情報ToolStripMenuItem.Name = "個人情報ToolStripMenuItem";
            this.個人情報ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.個人情報ToolStripMenuItem.Text = "個人情報";
            // 
            // ログアウトToolStripMenuItem
            // 
            this.ログアウトToolStripMenuItem.Name = "ログアウトToolStripMenuItem";
            this.ログアウトToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ログアウトToolStripMenuItem.Text = "ログアウト";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 524);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "コーヒーストア管理";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 管理者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem アカウント情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 個人情報ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ログアウトToolStripMenuItem;
    }
}