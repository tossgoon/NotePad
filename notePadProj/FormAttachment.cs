using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace notePadProj
{
    public partial class FormAttachment : Form
    {
        private int projid;
        private OleDbConnection thisConn;
        public FormAttachment()
        {
            InitializeComponent();
        }
        public FormAttachment(int projid, OleDbConnection thisConn)
        {
            InitializeComponent();
            this.projid = projid;
            this.thisConn = thisConn;
            CProject proj = new CProject(projid, thisConn);
            txtProjName.Text = proj.ProjectName;//项目名称
            txtProjDate.Text = proj.ProjectDate;//项目日期
            txtProjCreateDate.Text = proj.CreateDate;//创建日期
            txtProjStatus.Text = proj.IsFinished ? "完成" : "未完成";//状态
            txtProjContent.Text = proj.Content;//内容
            txtFolderPath.Text = Application.StartupPath + "\\data\\fujian\\" + projid;
            List<CAttachment> attList = proj.GetAttList();
            foreach (CAttachment att in attList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvAttachment);
                row.Cells[dgvAttachment.Columns["colAttID"].Index].Value = att.AttID;
                row.Cells[dgvAttachment.Columns["colAttName"].Index].Value = att.AttName;
                row.Cells[dgvAttachment.Columns["colAttFilePath"].Index].Value = att.AttFilePath;
                row.Cells[dgvAttachment.Columns["colAttUploadDate"].Index].Value = att.UploadDate;
                row.Height = 35;
                dgvAttachment.Rows.Add(row);
            }
        }

        private void dgvAttachment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (e.RowIndex >= 0
                && e.ColumnIndex >= 0
                && dgv.Columns[e.ColumnIndex].Name == "colAttOpen")
            {
                string filePath = dgv.Rows[e.RowIndex].Cells["colAttFilePath"].Value.ToString();//附件路径
                if (System.IO.File.Exists(filePath))
                {
                    try
                    {
                        System.Diagnostics.Process p = new System.Diagnostics.Process();
                        p.StartInfo.UseShellExecute = true;
                        p.StartInfo.FileName = filePath;
                        p.Start();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void dgvAttachment_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0
                && dgvAttachment.Rows[e.RowIndex] != null)
            {
                string filePath = dgvAttachment.Rows[e.RowIndex].Cells["colAttFilePath"].Value.ToString();//附件路径
                if (IsFilePicture(filePath))
                {
                    //pboxAtt.Image = Image.FromFile(filePath);
                    pboxAtt.Image = GetImageFromPath(filePath);
                }
                else
                {
                    pboxAtt.Image = null;
                }
            }
        }
        public static bool IsFilePicture(string filePath)
        {
            //如果文件不存在，返回假
            if(!System.IO.File.Exists(filePath))
            {
                return false;
            }
            bool isFilePicture = false;
            string fileType = filePath.Substring(filePath.LastIndexOf(".") + 1);
            switch (fileType.ToLower())
            {
                case "jpg":
                case "jpeg":
                case "png":
                case "bmp":
                case "tiff":
                case "ico":
                    isFilePicture = true;
                    break;
                default:
                    isFilePicture = false;
                    break;
            }
            return isFilePicture;
        }
        private System.Drawing.Image GetImageFromPath(string path)
        {
            System.IO.FileStream fs = new System.IO.FileStream(path, System.IO.FileMode.Open);
            System.Drawing.Image result = Image.FromStream(fs);
            fs.Close();
            fs.Dispose();
            return result;
        }

        private void dgvAttachment_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0
                && dgvAttachment.Columns[e.ColumnIndex].Name.Equals("colAttPreview"))
            {
                DataGridView dgv = sender as DataGridView;
                string filePath = dgv.Rows[e.RowIndex].Cells["colAttFilePath"].Value.ToString();//附件路径
                if (IsFilePicture(filePath))
                {
                    e.Value = GetImageFromPath(filePath);
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            string folderPath = Application.StartupPath + "\\data\\fujian\\" + projid;
            System.Diagnostics.Process.Start(folderPath);
        }
    }
}
