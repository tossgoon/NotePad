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
namespace notePadProj
{
    public partial class FormMain : Form
    {
        private OleDbConnection thisConn;
        private static int TOPRED = 220;//199
        private static int TOPGREEN = 20;//237
        private static int TOPBLUE = 60;//60
        private double notifyday = 1;//提醒日期
        private double refreshhour = 1;//刷新时间
        private string emailAddress;//接收邮件地址
        private string sendEmail;//邮件发送地址
        private string sendEmailPasswrod;//邮件发送地址密码
        private string sendEmailServer;//发送邮件服务器
        public FormMain()
        {
            InitializeComponent();
            //数据库连接字符串
            thisConn = CDBOperate.GetConnection();
            try
            {
                thisConn.Open();
                //读取提醒天数，默认为1天
                OleDbCommand thisCommand = thisConn.CreateCommand();
                thisCommand.CommandText = "SELECT sysvalue FROM setting"
                    + " WHERE syskey='notifyday'";
                object day = thisCommand.ExecuteScalar();
                if (day != null)
                {
                    if (!double.TryParse(day.ToString(), out notifyday))
                    {
                        notifyday = 1;
                    }
                }
                else
                {
                    notifyday = 1;
                }
                //读取刷新时间，默认为1小时
                thisCommand.CommandText = "SELECT sysvalue FROM setting"
                    + " WHERE syskey='refreshhour'";
                object hours = thisCommand.ExecuteScalar();
                if (hours != null)
                {
                    if (!double.TryParse(hours.ToString(), out refreshhour))
                    {
                        refreshhour = 1;
                    }
                }
                else
                {
                    refreshhour = 1;
                }
                timerNotify.Interval = (int)(refreshhour * 3600000);
                //读取接收邮件地址
                thisCommand.CommandText = "SELECT email FROM tbuser"
                    + " WHERE username='admin'";
                if (thisCommand.ExecuteScalar() != null)
                {
                    emailAddress = thisCommand.ExecuteScalar().ToString();
                }
                //读取发送邮件地址

                thisCommand.CommandText = "SELECT sysvalue FROM setting"
                    + " WHERE syskey='sendemail'";
                if (thisCommand.ExecuteScalar() != null)
                {
                    sendEmail = thisCommand.ExecuteScalar().ToString();
                }
                //读取发送邮件密码
                thisCommand.CommandText = "SELECT sysvalue FROM setting"
                    + " WHERE syskey='sendemailpass'";
                if (thisCommand.ExecuteScalar() != null)
                {
                    sendEmailPasswrod = thisCommand.ExecuteScalar().ToString();
                }
                //读取发送邮件服务器
                thisCommand.CommandText = "SELECT sysvalue FROM setting"
                    + " WHERE syskey='emailserver'";
                if (thisCommand.ExecuteScalar() != null)
                {
                    sendEmailServer = thisCommand.ExecuteScalar().ToString();
                }
                thisCommand.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void tbtnNewProj_Click(object sender, EventArgs e)
        {
            FormProj form = new FormProj(thisConn);
            form.eventInsertProj += new FormProj.insertProjHandler(form_eventInsertProj);
            form.ShowDialog();
        }

        private void form_eventInsertProj(int projid, string projname, string projdate, string content, bool istop)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvNotepad);
            row.Cells[dgvNotepad.Columns["colProjID"].Index].Value = projid;
            row.Cells[dgvNotepad.Columns["colProjName"].Index].Value = projname;
            row.Cells[dgvNotepad.Columns["colProjDate"].Index].Value = projdate;
            row.Cells[dgvNotepad.Columns["colProjCreateDate"].Index].Value = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
            row.Cells[dgvNotepad.Columns["colProjContent"].Index].Value = content;
            if (istop)
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                row.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            }
            dgvNotepad.Rows.Insert(0, row);
            dgvNotepad.Rows[0].Selected = true;
        }

        private void tbtnUpdateProj_Click(object sender, EventArgs e)
        {
            int projid = GetCurrentRowProjID();
            if (projid > 0)
            {
                FormProj form = new FormProj(projid, thisConn);
                form.eventUpdateProj += new FormProj.updateProjHandler(form_eventUpdateProj);
                form.ShowDialog();
            }
        }
        private int GetCurrentRowProjID()
        {
            int projid = 0;
            if (tbCtrlMain.SelectedTab == tbPageNotFinish)
            {
                if (dgvNotepad.CurrentRow != null)
                {
                    projid = Convert.ToInt32(dgvNotepad.CurrentRow.Cells["colProjID"].Value);
                }
            }
            else if (tbCtrlMain.SelectedTab == tbPageFinish)
            {
                if (dgvNotepadFinished.CurrentRow != null)
                {
                    projid = Convert.ToInt32(dgvNotepadFinished.CurrentRow.Cells["colProjIDFinished"].Value);
                }
            }
            else if (tbCtrlMain.SelectedTab == tbPageSearch)
            {
                if (dgvProjSearch.CurrentRow != null)
                {
                    projid = Convert.ToInt32(dgvProjSearch.CurrentRow.Cells["colProjIDSearch"].Value);
                }
            }
            return projid;
        }
        private DataGridView GetCurrentDgv()
        {
            DataGridView dgv;
            if (tbCtrlMain.SelectedTab == tbPageNotFinish)
            {
                dgv = dgvNotepad;
            }
            else if (tbCtrlMain.SelectedTab == tbPageFinish)
            {
                dgv = dgvNotepadFinished;
            }
            else
            {
                dgv = dgvProjSearch;
            }
            return dgv;
        }
        /// <summary>
        /// 增加到已完成
        /// </summary>
        /// <param name="projid"></param>
        private void InsertRow2Finished(CProject proj)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvNotepadFinished);
            row.Cells[dgvNotepadFinished.Columns["colProjIDFinished"].Index].Value = proj.ProjectID;
            row.Cells[dgvNotepadFinished.Columns["colProjNameFinished"].Index].Value = proj.ProjectName;
            row.Cells[dgvNotepadFinished.Columns["colProjDateFinished"].Index].Value = proj.ProjectDate;
            row.Cells[dgvNotepadFinished.Columns["colProjCreateDateFinished"].Index].Value = proj.CreateDate;
            row.Cells[dgvNotepadFinished.Columns["colProjContentFinished"].Index].Value = proj.Content;
            row.Cells[dgvNotepadFinished.Columns["colProjFinishedDateFinished"].Index].Value = proj.FinishDate;
            if (proj.IsTop)
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                row.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            }
            dgvNotepadFinished.Rows.Insert(0, row);
        }
        /// <summary>
        /// 增加到未完成
        /// </summary>
        /// <param name="projid"></param>
        private void InsertRow2NotFinished(CProject proj)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dgvNotepad);
            row.Cells[dgvNotepad.Columns["colProjID"].Index].Value = proj.ProjectID;
            row.Cells[dgvNotepad.Columns["colProjName"].Index].Value = proj.ProjectName;
            row.Cells[dgvNotepad.Columns["colProjDate"].Index].Value = proj.ProjectDate;
            row.Cells[dgvNotepad.Columns["colProjCreateDate"].Index].Value = proj.CreateDate;
            row.Cells[dgvNotepad.Columns["colProjContent"].Index].Value = proj.Content;
            if (proj.IsTop)
            {
                row.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                row.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
            }
            dgvNotepad.Rows.Insert(0, row);
        }
        public void form_eventUpdateProj(int projid)
        {
            //1.刷新工程
            CProject proj = new CProject(projid, thisConn);//工程
            DataGridView dgv = GetCurrentDgv();
            if (dgv == dgvNotepad)//未完成
            {
                if (proj.IsFinished)
                {
                    //如果已完成，将数据从未完成中转移到已完成界面
                    //1.从未完成中删除
                    dgv.Rows.Remove(dgv.CurrentRow);
                    //2.在已完成中增加
                    InsertRow2Finished(proj);
                }
                else
                {
                    dgv.CurrentRow.Cells[dgvNotepad.Columns["colProjName"].Index].Value = proj.ProjectName;
                    dgv.CurrentRow.Cells[dgvNotepad.Columns["colProjDate"].Index].Value = proj.ProjectDate;
                    dgv.CurrentRow.Cells[dgvNotepad.Columns["colProjContent"].Index].Value = proj.Content;
                    if (proj.IsTop)
                    {
                        dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                        dgv.CurrentRow.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                    }
                    else
                    {
                        dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                        dgv.CurrentRow.DefaultCellStyle.Font = new Font("宋体", 9);
                    }
                }
            }
            else if (dgv == dgvNotepadFinished)//已完成
            {
                if (!proj.IsFinished)
                {
                    //如果已完成，将数据从未完成中转移到已完成界面
                    //1.从未完成中删除
                    dgv.Rows.Remove(dgv.CurrentRow);
                    //2.在未完成中增加
                    InsertRow2NotFinished(proj);
                }
                else
                {
                    dgv.CurrentRow.Cells[dgvNotepadFinished.Columns["colProjNameFinished"].Index].Value = proj.ProjectName;
                    dgv.CurrentRow.Cells[dgvNotepadFinished.Columns["colProjDateFinished"].Index].Value = proj.ProjectDate;
                    dgv.CurrentRow.Cells[dgvNotepadFinished.Columns["colProjContentFinished"].Index].Value = proj.Content;
                    if (proj.IsTop)
                    {
                        dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                        dgv.CurrentRow.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                    }
                    else
                    {
                        dgv.CurrentRow.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                        dgv.CurrentRow.DefaultCellStyle.Font = new Font("宋体", 9);
                    }
                }
            }
            else if (dgv == dgvProjSearch)
            {
                dgv.CurrentRow.Cells[dgv.Columns["colProjNameSearch"].Index].Value = proj.ProjectName;
                dgv.CurrentRow.Cells[dgv.Columns["colProjDateSearch"].Index].Value = proj.ProjectName;
                dgv.CurrentRow.Cells[dgv.Columns["colProjFinishStatusSearch"].Index].Value = proj.IsFinished ? "完成" : "未完成";
                dgv.CurrentRow.Cells[dgv.Columns["colProjFinishDateSearch"].Index].Value = proj.FinishDate;
                dgv.CurrentRow.Cells[dgv.Columns["colProjContentSearch"].Index].Value = proj.Content;
            }
        }
        private void tbtnDeleteProj_Click(object sender, EventArgs e)
        {
            int projid = GetCurrentRowProjID();//得到当前行的工程ID
            if (projid > 0
                && MessageBox.Show("是否从数据库中删除该条事项?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                CProject proj = new CProject(projid, thisConn);
                proj.DeleteProj();
                DataGridView dgv = GetCurrentDgv();
                if (dgv.CurrentRow != null)
                {
                    dgv.Rows.Remove(dgv.CurrentRow);
                }
                //如果是在查询界面删除，需要在其他两个界面进行删除
                if (tbCtrlMain.SelectedTab == tbPageSearch)
                {
                    if (proj.IsFinished)
                    {
                        for (int i = 0; i < dgvNotepadFinished.Rows.Count; i++)
                        {
                            int otherProjID = Convert.ToInt32(dgvNotepadFinished.Rows[i].Cells["colProjIDFinished"].Value);
                            if (projid == otherProjID)
                            {
                                dgvNotepadFinished.Rows.RemoveAt(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < this.dgvNotepad.Rows.Count; i++)
                        {
                            int otherProjID = Convert.ToInt32(dgvNotepad.Rows[i].Cells["colProjID"].Value);
                            if (projid == otherProjID)
                            {
                                dgvNotepad.Rows.RemoveAt(i);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void tbtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataBase();
        }
        private void tbtnChangeProjStatus_Click(object sender, EventArgs e)
        {
            if (tbCtrlMain.SelectedTab == tbPageNotFinish)
            {
                int projid = GetCurrentRowProjID();
                if (projid > 0)
                {
                    CProject proj = new CProject(projid, thisConn);
                    proj.UpdateProjStatus(true);
                    //未完成中删除一行
                    dgvNotepad.Rows.Remove(dgvNotepad.CurrentRow);
                    //已完成中增加一行
                    InsertRow2Finished(proj);
                }
            }
            else if (tbCtrlMain.SelectedTab == tbPageFinish)
            {
                int projid = GetCurrentRowProjID();
                if (projid > 0)
                {
                    CProject proj = new CProject(projid, thisConn);
                    proj.UpdateProjStatus(false);
                    //未完成中删除一行
                    dgvNotepadFinished.Rows.Remove(dgvNotepadFinished.CurrentRow);
                    //已完成中增加一行
                    InsertRow2NotFinished(proj);
                }
            }
        }

        private void tbtnAttachment_Click(object sender, EventArgs e)
        {
            int projid = GetCurrentRowProjID();
            if (projid > 0)
            {
                FormAttachment formAtt = new FormAttachment(projid, thisConn);
                formAtt.ShowDialog();
            }
        }

        private void tbtnExportProj_Click(object sender, EventArgs e)
        {
            //if (dgvNotepad.SelectedRows.Count > 0
            //   && dgvNotepad.SelectedRows[0] != null)
            //{
            //    SaveFileDialog wordDlg = new SaveFileDialog();
            //    wordDlg.Filter = "Word 2003(*.doc)|*.doc|Word 2007(*.docx)|*.docx";
            //    wordDlg.AddExtension = true;
            //    if (wordDlg.ShowDialog() == DialogResult.OK)
            //    {
            //        int projid = Convert.ToInt32(dgvNotepad.SelectedRows[0].Cells["colProjID"].Value);
            //        string filename = wordDlg.FileName;
            //        CExportWord ew = new CExportWord();
            //        ew.filename = filename;
            //        ew.projid = projid;
            //        //多线程导出数据至word
            //        ParameterizedThreadStart parStart = new ParameterizedThreadStart(Export2Word);
            //        Thread thread = new Thread(parStart);
            //        object o = ew;
            //        thread.Start(o);
            //    }
            //}
            List<CProject> projList = GetSelectedProject();
            if (projList.Count == 0)
            {
                MessageBox.Show("请选择导出事项");
            }
            else
            {
                //创建新线程，导出到word
                SaveFileDialog wordDlg = new SaveFileDialog();
                wordDlg.Filter = "Word 2003(*.doc)|*.doc|Word 2007(*.docx)|*.docx";
                wordDlg.AddExtension = true;
                if (wordDlg.ShowDialog() == DialogResult.OK)
                {
                    string filename = wordDlg.FileName;
                    CExportWord ew = new CExportWord();
                    ew.filename = filename;
                    ew.projList = projList;
                    //多线程导出数据至word
                    ParameterizedThreadStart parStart = new ParameterizedThreadStart(Export2Word);
                    Thread thread = new Thread(parStart);
                    object o = ew;
                    thread.Start(o);
                }
            }
        }
        private void Export2Word(object projwd)
        {
            CExportWord ew = (CExportWord)projwd;
            List<CProject> projList = ew.projList;
            //int pid = ew.projid;
            //CProject proj = new CProject(pid, thisConn);
            CWordProj wproj = new CWordProj(projList);//SaveProjListByModel
            wproj.SaveProjListByModel(ew.filename);
        }

        private void timerNotify_Tick(object sender, EventArgs e)
        {
            RefreshDataBase();
        }
        /// <summary>
        /// 刷新数据库
        /// </summary>
        private void RefreshDataBase()
        {
            timerNotify.Enabled = false;
            Thread thread = new Thread(new ThreadStart(Notify));
            thread.Start();
        }
        private void 用户设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting formSetting = new FormSetting(notifyday, refreshhour, emailAddress, sendEmail, sendEmailPasswrod, sendEmailServer, thisConn);
            formSetting.eventUpdateNotify += formSetting_eventUpdateNotify;
            formSetting.ShowDialog();
        }

        void formSetting_eventUpdateNotify(double notifyDays, double refreshHours, string email, string sendemail, string sendemailpassword, string sendemailserver)
        {
            notifyday = notifyDays;
            refreshhour = refreshHours;
            timerNotify.Interval = (int)(refreshHours * 3600000);
            sendEmail = sendemail;
            sendEmailPasswrod = sendemailpassword;
            sendEmailServer = sendemailserver;
            emailAddress = email;
        }
        private void Notify()
        {
            CNotify notify = CNotify.GetInstance(thisConn);
            this.Invoke((MethodInvoker)delegate()
            {
                notify.Refresh(notifyday, emailAddress);
                timerNotify.Enabled = true;
            });
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon1.Visible = false;
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            //1.刷新工程（未完成、已完成）
            RefreshProj();
            //2.刷新数据库
            RefreshDataBase();
            //3.控件初始化
            cboxProjFinish.SelectedIndex = 0;
        }

        private void tbCtrlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbCtrlMain.SelectedIndex == 0)
            {
                tbtnChangeProjStatus.Enabled = true;
                tbtnTop.Enabled = true;
                tbtnChangeProjStatus.Text = "完成";
            }
            else if (tbCtrlMain.SelectedIndex == 1)
            {
                tbtnChangeProjStatus.Enabled = true;
                tbtnTop.Enabled = true;
                tbtnChangeProjStatus.Text = "取消完成";
            }
            else
            {
                tbtnChangeProjStatus.Enabled = false;
                tbtnTop.Enabled = false;
            }
        }

        private void tbtnRefreshProj_Click(object sender, EventArgs e)
        {
            RefreshProj();
        }
        /// <summary>
        /// 刷新工程
        /// </summary>
        private void RefreshProj()
        {
            //1.刷新未完成
            List<CProject> projlist = CProject.GetProjListByCondition("", "", "", "", "未完成", thisConn);
            dgvNotepad.Rows.Clear();
            foreach (CProject proj in projlist)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNotepad);
                row.Cells[dgvNotepad.Columns["colProjID"].Index].Value = proj.ProjectID;
                row.Cells[dgvNotepad.Columns["colProjName"].Index].Value = proj.ProjectName;
                row.Cells[dgvNotepad.Columns["colProjDate"].Index].Value = proj.ProjectDate;
                row.Cells[dgvNotepad.Columns["colProjCreateDate"].Index].Value = proj.CreateDate;
                row.Cells[dgvNotepad.Columns["colProjContent"].Index].Value = proj.Content;
                if (proj.IsTop)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                    row.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                }
                dgvNotepad.Rows.Add(row);
            }
            //2.刷新已完成
            List<CProject> projFinishList = CProject.GetProjListByCondition("", "", "", "", "已完成", thisConn);
            dgvNotepadFinished.Rows.Clear();
            foreach (CProject proj in projFinishList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvNotepadFinished);
                row.Cells[dgvNotepadFinished.Columns["colProjIDFinished"].Index].Value = proj.ProjectID;
                row.Cells[dgvNotepadFinished.Columns["colProjNameFinished"].Index].Value = proj.ProjectName;
                row.Cells[dgvNotepadFinished.Columns["colProjDateFinished"].Index].Value = proj.ProjectDate;
                row.Cells[dgvNotepadFinished.Columns["colProjCreateDateFinished"].Index].Value = proj.CreateDate;
                row.Cells[dgvNotepadFinished.Columns["colProjContentFinished"].Index].Value = proj.Content;
                row.Cells[dgvNotepadFinished.Columns["colProjFinishedDateFinished"].Index].Value = proj.FinishDate;
                if (proj.IsTop)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                    row.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                }
                dgvNotepadFinished.Rows.Add(row);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //1.keyword
            string keyword = txtKeyWords.Text;
            //2.是否完成
            string finishStr = cboxProjFinish.Text;
            //3.日期类型
            string dateType = cboxProjDateType.Text;
            //4.起始日期.终止日期
            string beginDate = "", endDate = "";
            if (dateType != "")
            {
                if (dtpBeginDateSearch.Checked)
                {
                    beginDate = dtpBeginDateSearch.Value.ToString("yyyy-MM-dd");
                }
                if (dtpEndDateSearch.Checked)
                {
                    endDate = dtpEndDateSearch.Value.AddDays(1).ToString("yyyy-MM-dd");
                }
            }
            List<CProject> projList = CProject.GetProjListByCondition(keyword, dateType, beginDate, endDate, finishStr, thisConn);
            dgvProjSearch.Rows.Clear();
            foreach (CProject proj in projList)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvProjSearch);
                row.Cells[dgvProjSearch.Columns["colProjIDSearch"].Index].Value = proj.ProjectID;
                row.Cells[dgvProjSearch.Columns["colProjNameSearch"].Index].Value = proj.ProjectName;
                row.Cells[dgvProjSearch.Columns["colProjDateSearch"].Index].Value = proj.ProjectDate;
                row.Cells[dgvProjSearch.Columns["colProjCreateDateSearch"].Index].Value = proj.CreateDate;
                row.Cells[dgvProjSearch.Columns["colProjFinishStatusSearch"].Index].Value = proj.IsFinished ? "完成" : "未完成";
                row.Cells[dgvProjSearch.Columns["colProjFinishDateSearch"].Index].Value = proj.FinishDate;
                row.Cells[dgvProjSearch.Columns["colProjContentSearch"].Index].Value = proj.Content;
                if (proj.IsTop)
                {
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                    row.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                }
                dgvProjSearch.Rows.Add(row);
            }
        }

        private void cbx_tongji_dateselect_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime StartDate = new DateTime();//起始日期
            DateTime EndDate = new DateTime();//结束日期
            if (cboxDateChooseSearch.SelectedIndex == 5)
            {
                dtpBeginDateSearch.Checked = false;
                dtpEndDateSearch.Checked = false;
            }
            else if (this.cboxDateChooseSearch.SelectedIndex != -1)
            {
                switch (cboxDateChooseSearch.SelectedIndex)
                {
                    case 0://本月
                        StartDate = DateTime.Today.AddDays(1 - DateTime.Today.Day);//本月1号
                        EndDate = DateTime.Today;//今日
                        break;
                    case 1://上一月
                        StartDate = DateTime.Parse(DateTime.Today.ToString("yyyy-MM-01")).AddMonths(-1);
                        EndDate = DateTime.Parse(DateTime.Today.ToString("yyyy-MM-01")).AddDays(-1);
                        break;
                    case 2://本季度
                        StartDate = DateTime.Parse(DateTime.Now.AddMonths(0 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01"));//
                        EndDate = DateTime.Parse(DateTime.Now.AddMonths(3 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01")).AddDays(-1);
                        break;
                    case 3://上季度
                        StartDate = DateTime.Parse(DateTime.Now.AddMonths(-3 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01"));//
                        EndDate = DateTime.Parse(DateTime.Now.AddMonths(0 - ((DateTime.Now.Month - 1) % 3)).ToString("yyyy-MM-01")).AddDays(-1);
                        break;
                    case 4://本年
                        StartDate = DateTime.Parse(DateTime.Today.ToString("yyyy-01-01"));//年初1月1号
                        EndDate = DateTime.Today;//今日    
                        break;
                    default:
                        break;
                }
                this.dtpBeginDateSearch.Value = StartDate;
                this.dtpEndDateSearch.Value = EndDate;
            }
        }

        private void cboxProjDateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxProjDateType.SelectedIndex == 2)//完成日期
            {
                cboxProjFinish.Text = "已完成";
            }
            if (cboxProjDateType.SelectedIndex == 3)//清空日期
            {
                cboxDateChooseSearch.Text = "";
            }
        }

        private void tbtnSelectAll_Click(object sender, EventArgs e)
        {
            DataGridView dgv = GetCurrentDgv();
            if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == 1)
            {
                dgv.CurrentCell = dgv.CurrentRow.Cells[2];
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[1].Value = true;
            }
        }

        private void tbtnNoSelect_Click(object sender, EventArgs e)
        {
            DataGridView dgv = GetCurrentDgv();
            if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == 1)
            {
                dgv.CurrentCell = dgv.CurrentRow.Cells[2];
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                dgv.Rows[i].Cells[1].Value = false;
            }
        }

        private void tbtnReverseSelect_Click(object sender, EventArgs e)
        {
            DataGridView dgv = GetCurrentDgv();
            if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == 1)
            {
                dgv.CurrentCell = dgv.CurrentRow.Cells[2];
            }
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Cells[1].Value == null)
                {
                    dgv.Rows[i].Cells[1].Value = true;
                }
                else
                {
                    bool v = (bool)dgv.Rows[i].Cells[1].Value;
                    dgv.Rows[i].Cells[1].Value = !v;
                }
            }
        }

        private void tbtnEmail_Click(object sender, EventArgs e)
        {
            List<CProject> projList = GetSelectedProject();
            if (projList.Count == 0)
            {
                MessageBox.Show("请选择事项");
                return;
            }
            //发送邮件
            try
            {
                if (emailAddress != "")
                {
                    string emailContent = "";
                    int i = 1;
                    foreach (CProject proj in projList)
                    {
                        string finishStr = "";
                        if (proj.IsFinished)
                        {
                            finishStr = "完成（完成日期:" + proj.FinishDate + ")";
                        }
                        else
                        {
                            finishStr = "未完成";
                        }
                        emailContent += i++.ToString() + "."
                            + proj.ProjectName + "<br/>"
                            + "&nbsp;&nbsp;&nbsp;&nbsp;创建日期:" + proj.CreateDate + "<br/>"
                            + "&nbsp;&nbsp;&nbsp;&nbsp;事项日期:" + proj.ProjectDate + "<br/>"
                            + "&nbsp;&nbsp;&nbsp;&nbsp;完成情况:" + finishStr + "<br/>"
                            + "&nbsp;&nbsp;&nbsp;&nbsp;事项内容:" + proj.Content + "<br/>";
                    }
                    CEmail omail = new CEmail();
                    //omail.SendMail("007xiaoming@163.com",
                    //    "jkinfo",
                    //    emailAddress,
                    //    "消息提醒" + DateTime.Now.ToString("yyyy/MM/dd hh:mm"),
                    //    emailContent,
                    //    "007xiaoming@163.com",
                    //    "yihushui123",
                    //    "smtp.163.com", "");
                    if (omail.SendMail(sendEmail,
                         "jkinfo",
                         emailAddress,
                         "消息提醒" + DateTime.Now.ToString("yyyy/MM/dd hh:mm"),
                         emailContent,
                         sendEmail,
                         sendEmailPasswrod,
                         sendEmailServer, ""))
                    {
                        MessageBox.Show("发送成功");
                    }
                    else
                    {
                        MessageBox.Show("发送不成功，请检查邮箱设置信息");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private List<CProject> GetSelectedProject()
        {
            DataGridView dgv = GetCurrentDgv();
            if (dgv.CurrentCell != null && dgv.CurrentCell.ColumnIndex == 1)
            {
                dgv.CurrentCell = dgv.CurrentRow.Cells[2];
            }
            List<CProject> projList = new List<CProject>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[1].Value != null)
                {
                    bool check = (bool)row.Cells[1].Value;
                    if (check)
                    {
                        int projid = Convert.ToInt32(row.Cells[0].Value);
                        CProject proj = new CProject(projid, thisConn);
                        projList.Add(proj);
                    }
                }
            }
            return projList;
        }

        private void tbtnTop_Click(object sender, EventArgs e)
        {
            DataGridView dgv = GetCurrentDgv();
            if (dgv.CurrentRow != null)
            {
                if (dgv.CurrentRow.DefaultCellStyle.ForeColor == Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE))
                {
                    //取消置顶
                    int projid = GetCurrentRowProjID();
                    CProject proj = new CProject(projid, thisConn);
                    proj.UpdateProjTop(false);
                    //更新
                    DataGridViewRow rowClone = CopyDataGriViewRow(dgv.CurrentRow);
                    rowClone.DefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 0);
                    rowClone.DefaultCellStyle.Font = new Font("宋体", 9);
                    dgv.Rows.Add(rowClone);
                    dgv.Rows.Remove(dgv.CurrentRow);
                }
                else
                {
                    tbtnTop.Text = "置顶";
                    //取消置顶
                    int projid = GetCurrentRowProjID();
                    CProject proj = new CProject(projid, thisConn);
                    proj.UpdateProjTop(true);
                    //更新
                    DataGridViewRow rowClone = CopyDataGriViewRow(dgv.CurrentRow);
                    rowClone.DefaultCellStyle.ForeColor = Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE);
                    rowClone.DefaultCellStyle.Font = new Font("宋体", 9, FontStyle.Bold);
                    dgv.Rows.Insert(0, rowClone);
                    dgv.Rows.Remove(dgv.CurrentRow);
                }
            }
        }

        private void dgvNotepad_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv.Rows[e.RowIndex] != null)
                {
                    if (dgv.Rows[e.RowIndex].DefaultCellStyle.ForeColor == Color.FromArgb(TOPRED, TOPGREEN, TOPBLUE))
                    {
                        //置顶
                        tbtnTop.Text = "取消置顶";
                    }
                    else
                    {
                        tbtnTop.Text = "置顶";
                    }
                }
            }

        }
        /// <summary> 
        /// 复制一个行数据 
        /// </summary> 
        /// <param name="myCopyedDataGridViewRow"> </param> 
        /// <returns> </returns> 
        private DataGridViewRow CopyDataGriViewRow(DataGridViewRow myCopyedDataGridViewRow)
        {
            DataGridViewRow myNewDataGridViewRow = myCopyedDataGridViewRow.Clone() as DataGridViewRow;
            for (int i = 0; i < myCopyedDataGridViewRow.Cells.Count; i++)
            {
                myNewDataGridViewRow.Cells[i].Value = myCopyedDataGridViewRow.Cells[i].Value;
            }
            return myNewDataGridViewRow;
        }
    }
    public struct CExportWord
    {
        public int projid;
        public List<CProject> projList;
        public string filename;
    }
}