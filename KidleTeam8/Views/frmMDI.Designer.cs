namespace KindleTeam8.Views
{
    partial class frmMDI
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
            this.mnsMDI = new System.Windows.Forms.MenuStrip();
            this.tsmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mCreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.mViews = new System.Windows.Forms.ToolStripMenuItem();
            this.mCreateDB = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.mnsMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMDI
            // 
            this.mnsMDI.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEdit,
            this.mViews,
            this.mCreateDB});
            this.mnsMDI.Location = new System.Drawing.Point(0, 0);
            this.mnsMDI.Name = "mnsMDI";
            this.mnsMDI.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnsMDI.Size = new System.Drawing.Size(632, 24);
            this.mnsMDI.TabIndex = 1;
            this.mnsMDI.Text = "mnsMDI";
            // 
            // tsmEdit
            // 
            this.tsmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFind,
            this.mCreateFolder});
            this.tsmEdit.Name = "tsmEdit";
            this.tsmEdit.Size = new System.Drawing.Size(39, 22);
            this.tsmEdit.Text = "Edit";
            // 
            // mFind
            // 
            this.mFind.Name = "mFind";
            this.mFind.Size = new System.Drawing.Size(133, 22);
            this.mFind.Text = "Find Folder";
            this.mFind.Click += new System.EventHandler(this.mFind_Click);
            // 
            // mCreateFolder
            // 
            this.mCreateFolder.Name = "mCreateFolder";
            this.mCreateFolder.Size = new System.Drawing.Size(133, 22);
            this.mCreateFolder.Text = "Create List";
            this.mCreateFolder.Click += new System.EventHandler(this.mCreateFolder_Click);
            // 
            // mViews
            // 
            this.mViews.Name = "mViews";
            this.mViews.Size = new System.Drawing.Size(49, 22);
            this.mViews.Text = "Views";
            this.mViews.Click += new System.EventHandler(this.mViews_Click);
            // 
            // mCreateDB
            // 
            this.mCreateDB.Name = "mCreateDB";
            this.mCreateDB.Size = new System.Drawing.Size(68, 22);
            this.mCreateDB.Text = "CreateDB";
            this.mCreateDB.Click += new System.EventHandler(this.mCreateDB_Click);
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(632, 24);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.mnsMDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsMDI;
            this.Name = "frmMDI";
            this.Text = "Màn Hình Chính";
            this.MdiChildActivate += new System.EventHandler(this.frmMDI_MdiChildActivate);
            this.mnsMDI.ResumeLayout(false);
            this.mnsMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.MenuStrip mnsMDI;
        private System.Windows.Forms.ToolStripMenuItem tsmEdit;
        private System.Windows.Forms.ToolStripMenuItem mFind;
        private System.Windows.Forms.ToolStripMenuItem mViews;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.ToolStripMenuItem mCreateFolder;
        private System.Windows.Forms.ToolStripMenuItem mCreateDB;
    }
}



