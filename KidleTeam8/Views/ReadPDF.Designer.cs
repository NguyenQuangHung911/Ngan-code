namespace KindleTeam8.Views
{
    partial class ReadPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReadPDF));
            this.mnsReadPDF = new System.Windows.Forms.MenuStrip();
            this.OpenPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.mFileLinked = new System.Windows.Forms.ToolStripMenuItem();
            this.mNote = new System.Windows.Forms.ToolStripMenuItem();
            this.mSaveNote = new System.Windows.Forms.ToolStripMenuItem();
            this.mFixNote = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailsPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.AdobeReadPDF = new AxAcroPDFLib.AxAcroPDF();
            this.mnsReadPDF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsReadPDF
            // 
            this.mnsReadPDF.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsReadPDF.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPDF,
            this.DetailsPDF,
            this.ExitPDF});
            this.mnsReadPDF.Location = new System.Drawing.Point(0, 0);
            this.mnsReadPDF.Name = "mnsReadPDF";
            this.mnsReadPDF.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnsReadPDF.Size = new System.Drawing.Size(464, 24);
            this.mnsReadPDF.TabIndex = 1;
            this.mnsReadPDF.Text = "mnsReadPDF";
            // 
            // OpenPDF
            // 
            this.OpenPDF.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileLinked,
            this.mNote});
            this.OpenPDF.Name = "OpenPDF";
            this.OpenPDF.Size = new System.Drawing.Size(44, 22);
            this.OpenPDF.Text = "View";
            this.OpenPDF.Click += new System.EventHandler(this.OpenPDF_Click);
            // 
            // mFileLinked
            // 
            this.mFileLinked.Name = "mFileLinked";
            this.mFileLinked.Size = new System.Drawing.Size(180, 22);
            this.mFileLinked.Text = "File Linked";
            this.mFileLinked.Click += new System.EventHandler(this.mFileLinked_Click);
            // 
            // mNote
            // 
            this.mNote.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSaveNote,
            this.mFixNote});
            this.mNote.Name = "mNote";
            this.mNote.Size = new System.Drawing.Size(180, 22);
            this.mNote.Text = "Note";
            // 
            // mSaveNote
            // 
            this.mSaveNote.Enabled = false;
            this.mSaveNote.Name = "mSaveNote";
            this.mSaveNote.Size = new System.Drawing.Size(123, 22);
            this.mSaveNote.Text = "Lưu Note";
            this.mSaveNote.Click += new System.EventHandler(this.mSaveNote_Click);
            // 
            // mFixNote
            // 
            this.mFixNote.Name = "mFixNote";
            this.mFixNote.Size = new System.Drawing.Size(123, 22);
            this.mFixNote.Text = "Sửa Note";
            this.mFixNote.Click += new System.EventHandler(this.mFixNote_Click);
            // 
            // DetailsPDF
            // 
            this.DetailsPDF.Name = "DetailsPDF";
            this.DetailsPDF.Size = new System.Drawing.Size(54, 22);
            this.DetailsPDF.Text = "Details";
            this.DetailsPDF.Click += new System.EventHandler(this.DetailsPDF_Click);
            // 
            // ExitPDF
            // 
            this.ExitPDF.Name = "ExitPDF";
            this.ExitPDF.Size = new System.Drawing.Size(38, 22);
            this.ExitPDF.Text = "Exit";
            this.ExitPDF.Click += new System.EventHandler(this.ExitPDF_Click);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(0, 24);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(464, 20);
            this.txtNote.TabIndex = 2;
            this.txtNote.Text = "Note: ";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // AdobeReadPDF
            // 
            this.AdobeReadPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdobeReadPDF.Enabled = true;
            this.AdobeReadPDF.Location = new System.Drawing.Point(0, 24);
            this.AdobeReadPDF.Name = "AdobeReadPDF";
            this.AdobeReadPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeReadPDF.OcxState")));
            this.AdobeReadPDF.Size = new System.Drawing.Size(464, 234);
            this.AdobeReadPDF.TabIndex = 0;
            // 
            // ReadPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 258);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.AdobeReadPDF);
            this.Controls.Add(this.mnsReadPDF);
            this.MainMenuStrip = this.mnsReadPDF;
            this.Name = "ReadPDF";
            this.Text = "Read";
            this.Load += new System.EventHandler(this.ReadPDF_Load);
            this.mnsReadPDF.ResumeLayout(false);
            this.mnsReadPDF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeReadPDF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AdobeReadPDF;
        private System.Windows.Forms.MenuStrip mnsReadPDF;
        private System.Windows.Forms.ToolStripMenuItem OpenPDF;
        private System.Windows.Forms.ToolStripMenuItem DetailsPDF;
        private System.Windows.Forms.ToolStripMenuItem ExitPDF;
        private System.Windows.Forms.ToolStripMenuItem mFileLinked;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ToolStripMenuItem mNote;
        private System.Windows.Forms.ToolStripMenuItem mSaveNote;
        private System.Windows.Forms.ToolStripMenuItem mFixNote;
    }
}