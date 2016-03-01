using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notePadProj
{
    public partial class FormNotify : Form
    {
        private List<CProject> projList;
        public FormNotify()
        {
            InitializeComponent();

        }
        public List<CProject> ProjectList
        {
            set
            {
                projList = value;
                //刷新
                dgvProjNotify.Rows.Clear();
                foreach (CProject proj in projList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvProjNotify);
                    row.Cells[dgvProjNotify.Columns["colProjID"].Index].Value = proj.ProjectID;
                    row.Cells[dgvProjNotify.Columns["colProjName"].Index].Value = proj.ProjectName;
                    row.Cells[dgvProjNotify.Columns["colProjDate"].Index].Value = proj.ProjectDate;
                    //工程日期
                    string spanstr = "";
                    DateTime projdate;
                    if (DateTime.TryParse(proj.ProjectDate, out projdate))
                    {
                        TimeSpan span = projdate - DateTime.Now;
                        if (span.TotalDays < 0)
                        {
                            spanstr = "超 " + Math.Abs(span.Days) + "天" + Math.Abs(span.Hours) + "小时";
                        }
                        else
                        {
                            spanstr = span.Days + "天" + span.Hours + "小时";
                        }
                    }
                    row.Cells[dgvProjNotify.Columns["colProjRemainTime"].Index].Value = spanstr;
                    dgvProjNotify.Rows.Add(row);
                }
            }
        }

        private void FormNotify_Load(object sender, EventArgs e)
        {
            int x = Screen.PrimaryScreen.WorkingArea.Right - this.Width;
            int y = Screen.PrimaryScreen.WorkingArea.Bottom - this.Height;
            this.Location = new Point(x, y);//设置窗体在屏幕右下角显示  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvProjNotify.SelectedRows.Count > 0
                && dgvProjNotify.SelectedRows[0] != null)
            {
                int projid = Convert.ToInt32(dgvProjNotify.SelectedRows[0].Cells["colProjID"].Value);

            }
        }
    }
}
