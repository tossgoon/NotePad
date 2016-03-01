using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.IO;
namespace notePadProj
{
    public partial class FormProj : Form
    {
        private bool isNewProject;//判断是否为新增一条事项
        private OleDbConnection thisConn;//数据库连接
        private int projid;//工程记录ID
        public delegate void insertProjHandler(int projid, string projname, string projdate, string content,bool istop);
        public event insertProjHandler eventInsertProj;//自定义插入事件
        public delegate void updateProjHandler(int projid);
        public event updateProjHandler eventUpdateProj;//自定义修改事件
        //private List<string> fileCopyList;//需要拷贝的附件列表
        private Dictionary<string, string> fileCopyList;//要拷贝的文件路径及新文件名称
        private string fileProjPath;//工程附件文件夹
        public FormProj()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 新增时调用该构造函数
        /// </summary>
        /// <param name="thisConn"></param>
        public FormProj(OleDbConnection thisConn)
        {
            this.thisConn = thisConn;
            projid = 0;
            InitializeComponent();
            chboxIsProjFinished.Visible = false;
            isNewProject = true;
            this.Text = "新增事项";
            dtProjDate.Value = DateTime.Now;
        }
        /// <summary>
        /// 数据更新时调用该构造函数
        /// </summary>
        /// <param name="projid"></param>
        /// <param name="thisConn"></param>
        public FormProj(int projid, OleDbConnection thisConn)
        {
            this.thisConn = thisConn;
            this.projid = projid;
            InitializeComponent();
            isNewProject = false;
            this.Text = "编辑事项";
            //从数据库读取信息并填充
            CProject proj = new CProject(projid, thisConn);
            txtProjName.Text = proj.ProjectName;
            txtProjDate.Text = proj.ProjectDate;
            rtxtProjContent.Text = proj.Content;
            this.chboxIsProjFinished.Checked = proj.IsFinished;
            this.chboxIsTop.Checked = proj.IsTop;
            //读取附件信息
            List<CAttachment> attList = proj.GetAttList();
            foreach (CAttachment att in attList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvAttachment);
                row.Cells[dgvAttachment.Columns["colAttID"].Index].Value = att.AttID;
                row.Cells[dgvAttachment.Columns["colAttName"].Index].Value = att.AttName;
                row.Cells[dgvAttachment.Columns["colAttFilePath"].Index].Value = att.AttFilePath;
                dgvAttachment.Rows.Add(row);
            }
        }
        private void tbtnClear_Click(object sender, EventArgs e)
        {
            isNewProject = true;//点击清空的时候，状态变为新增
            chboxIsProjFinished.Visible = false;
            this.Text = "新增事项";
            ClearControls();
        }
        /// <summary>
        /// 清空控件内容
        /// </summary>
        private void ClearControls()
        {
            txtProjName.Clear();
            rtxtProjContent.Clear();
            dgvAttachment.Rows.Clear();
            txtProjDate.Clear();
        }
        private void tbtnUploadAtt_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Multiselect = true;
            dlg.Title = "选择上传附件";
            dlg.Filter = "所有文件(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string[] files = dlg.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dgvAttachment);
                    string fileName = files[i].Substring(files[i].LastIndexOf("\\") + 1);//文件名
                    newRow.Cells[dgvAttachment.Columns["colAttName"].Index].Value = fileName;
                    newRow.Cells[dgvAttachment.Columns["colAttFilePath"].Index].Value = files[i];
                    dgvAttachment.Rows.Add(newRow);
                }
            }
        }

        private void tbtnSave_Click(object sender, EventArgs e)
        {
            //1.判断日期格式是否正确
            DateTime dtvalue;
            string dtvalueStr;//事件日期字符串
            if (DateTime.TryParse(txtProjDate.Text.Trim(), out dtvalue))
            {
                dtvalueStr = "#" + txtProjDate.Text.Trim() + "#";
            }
            else
            {
                dtvalueStr = "null";
            }
            //2.判断名称是否为空
            string projname = txtProjName.Text;
            if (projname.Trim() == "")
            {
                MessageBox.Show("事项名称为空。");
                return;
            }
            string content = rtxtProjContent.Text;
            if (isNewProject)
            {
                //数据库增加记录-project
                projid = CProject.InsertProj(projname, content, dtvalueStr, chboxIsTop.Checked, thisConn);
            }
            else
            {
                //修改数据库
                CProject proj = new CProject(projid, thisConn);
                proj.UpdateProj(projname, content, dtvalueStr, chboxIsProjFinished.Checked, chboxIsTop.Checked);
            }
            //1.创建工程文件夹
            fileProjPath = Application.StartupPath + "\\data\\fujian\\" + projid;//工程附件文件夹
            if (!Directory.Exists(fileProjPath))
            {
                Directory.CreateDirectory(fileProjPath);
            }
            //2.获取要上传的文件列表，并更新数据库中的附件表
            fileCopyList = new Dictionary<string, string>();
            foreach (DataGridViewRow row in dgvAttachment.Rows)
            {
                int attid = 0;
                if (row.Cells["colAttID"] != null
                    && row.Cells["colAttID"].Value != null
                    && row.Cells["colAttID"].Value.ToString() != "")
                {
                    int.TryParse(row.Cells["colAttID"].Value.ToString(), out attid);
                }
                if (attid == 0)//该行附件为新增
                {
                    string sourceFilePath = row.Cells["colAttFilePath"].Value.ToString();//源文件路径
                    string fileName = sourceFilePath.Substring(sourceFilePath.LastIndexOf("\\") + 1);//文件名
                    if (File.Exists(fileProjPath + "\\" + fileName))
                    {
                        fileName = fileName.Substring(0, fileName.LastIndexOf(".")) + "(2)" + fileName.Substring(fileName.LastIndexOf("."));
                    }
                    fileCopyList.Add(sourceFilePath, fileName);
                    CAttachment.InsertAttachment(projid, fileName, fileProjPath + "\\" + fileName, thisConn);//新增附件记录
                }
                else if (!row.Visible)//该行附件隐藏，需要删除
                {
                    CAttachment att = new CAttachment(attid);
                    att.DeleteAttachment(thisConn);
                }
            }
            //3.往新文件夹中拷贝文件
            if (fileCopyList.Count > 0)
            {
                Thread fileCopyThread = new Thread(new ThreadStart(FileCopyFun));
                fileCopyThread.Start();
            }
            else
            {
                if (isNewProject)
                {
                    if (MessageBox.Show("新增完成") == DialogResult.OK)
                    {
                        eventInsertProj(projid, txtProjName.Text, txtProjDate.Text, rtxtProjContent.Text,chboxIsTop.Checked);//附件拷贝完成之后，响应插入事件
                        ClearControls();
                    }

                }
                else
                {
                    if (MessageBox.Show("更新完成") == DialogResult.OK)
                    {
                        eventUpdateProj(projid);//附件拷贝完成之后，响应更新事件
                        this.Close();
                    }
                }
            }
        }
        private void FileCopyFun()
        {
            this.Invoke((MethodInvoker)delegate()
            {
                this.tstripProgress.Maximum = fileCopyList.Count;
                this.tstripProgress.Value = 0;
            });
            //拷贝附件
            int flag = 0;
            foreach (KeyValuePair<string, string> kv in fileCopyList)
            {
                this.Invoke((MethodInvoker)delegate()
                {
                    this.tstripLabel.Text = "正在拷贝第 " + (++flag).ToString() + " 个附件";
                });
                string sourceFile = kv.Key;//源文件名称
                string newFileName = this.fileProjPath + "\\" + kv.Value;//新文件名
                File.Copy(sourceFile, newFileName);//直接复制
                this.Invoke((MethodInvoker)delegate()
                {
                    this.tstripProgress.Value++;
                });
            }
            this.Invoke((MethodInvoker)delegate()
            {
                tstripLabel.Text = "已完成 ";
                this.tstripProgress.Value = 0;
                if (isNewProject)
                {
                    if (MessageBox.Show("新增完成") == DialogResult.OK)
                    {
                        eventInsertProj(projid, txtProjName.Text, txtProjDate.Text, rtxtProjContent.Text,chboxIsTop.Checked);//附件拷贝完成之后，响应插入事件
                        ClearControls();
                    }
                }
                else
                {
                    if (MessageBox.Show("更新完成") == DialogResult.OK)
                    {
                        eventUpdateProj(projid);//附件拷贝完成之后，响应更新事件
                        this.Close();
                    }
                }
            });
        }
        private void dtProjDate_ValueChanged(object sender, EventArgs e)
        {
            txtProjDate.Text = this.dtProjDate.Value.ToString("yyyy-MM-dd HH:mm");
        }

        private void dtProjDate_CloseUp(object sender, EventArgs e)
        {
            txtProjDate.Text = this.dtProjDate.Value.ToString("yyyy-MM-dd HH:mm");
        }

        private void dgvAttachment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Columns[e.ColumnIndex].Name == "colAttDelete")
                {
                    if (dgv.Rows[e.RowIndex].Cells["colAttID"] != null
                        && dgv.Rows[e.RowIndex].Cells["colAttID"].Value != null
                        && dgv.Rows[e.RowIndex].Cells["colAttID"].Value.ToString() != "")
                    {
                        dgv.Rows[e.RowIndex].Visible = false;//该行ID不为空，只是隐藏起来，保存时再删除
                    }
                    else
                    {
                        dgv.Rows.RemoveAt(e.RowIndex);//该行为空，直接删除
                    }
                }
                else if (dgv.Columns[e.ColumnIndex].Name == "colAttFileOpen")
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
        }
    }
}