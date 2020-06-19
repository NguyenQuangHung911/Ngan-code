using KindleTeam8;
using KindleTeam8.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//ngân cute vl

namespace KindleTeam8.Views
{
    public partial class ReadPDF : Form
    {
        //private string s;
        private ClassFile Files;
        private ClassFolder folder;
        public ReadPDF(ClassFile files, ClassFolder folders)
        {
            InitializeComponent();
            folder = new ClassFolder();
            folder = folders;
            this.Files = files;
            AdobeReadPDF.src = Files.namefile;
            if(Files.note != null)
            {
                txtNote.Text = "Note:" + Files.note;
            }    
        }
        private void DetailsPDF_Click(object sender, EventArgs e)
        {
            FileInfo info = new FileInfo(this.Files.namefile);
            MessageBox.Show("Tên tệp: " + info.Name + Environment.NewLine + "Thời gian tạo: " + info.CreationTime.ToLongTimeString() + Environment.NewLine +
                "Truy cập lần cuối: " + info.LastWriteTime.ToLongDateString() + Environment.NewLine + "Chỉnh sửa lần cuối: " + info.LastAccessTime.ToLongDateString() +
                Environment.NewLine + "Kích thước: " + (Convert.ToInt32(info.Length / 1024f)).ToString() + " KB", "Details", MessageBoxButtons.OK);
        }
        private void ExitPDF_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenPDF_Click(object sender, EventArgs e)
        {
            //AdobeReadPDF.src = Files.namefile;
        }
        private void mSaveNote_Click(object sender, EventArgs e)
        {
            Files.note = txtNote.Text;
            txtNote.Enabled = false;
        }
        private void mFixNote_Click(object sender, EventArgs e)
        {
            txtNote.Enabled = true;
            txtNote.Focus();
        }
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            mSaveNote.Enabled = true;
        }
        private void mFileLinked_Click(object sender, EventArgs e)
        {
            if(Files.path == null)
            {
                DialogResult xacnhan = MessageBox.Show(
                    "Chưa có File liên Kết, bạn có muốn tạo không?", "Thông Báo",
                    MessageBoxButtons.OKCancel);
                if(xacnhan == DialogResult.OK)
                {
                    OpenFileDialog ChooseFile = new OpenFileDialog();
                    ChooseFile.Filter = "PDF|*.pdf";
                    if (ChooseFile.ShowDialog() == DialogResult.OK)
                    {
                        Files.path = ChooseFile.FileName;
                        AdobeReadPDF.src = Files.path;
                    }
                }    
            }
            else
            {
                DialogResult xacnhan = MessageBox.Show(
                      "File liên Kết: "+Files.path+", bạn có muốn mở không?", "Thông Báo",
                      MessageBoxButtons.OKCancel);
                if(xacnhan == DialogResult.OK)
                {
                    int index = folder.listfile.ToList<ClassFile>().FindIndex(
                        x => x.namefile == Files.path);
                    Files = folder.listfile.ToList<ClassFile>()[index];
                    AdobeReadPDF.src = Files.namefile;
                }    
            }    
        }
        //Đọc File
        private void ReadPDF_Load(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có muốn mở file được chọn không",
                "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(xacnhan == DialogResult.Yes)
            {
                AdobeReadPDF.src = Files.namefile;
            }    
        }
    }
}