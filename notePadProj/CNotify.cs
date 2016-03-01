using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Threading;
namespace notePadProj
{
    class CNotify
    {
        private static CNotify notify;
        private OleDbConnection thisConn;
        private static FormNotify notifyForm;
        private CNotify(OleDbConnection thisConn)
        {
            this.thisConn = thisConn;
        }
        public static CNotify GetInstance(OleDbConnection thisConn)
        {
            if (notify == null)
            {
                notify = new CNotify(thisConn);
            }
            return notify;
        }
        public static FormNotify SetFormNotify()
        {
            if (notifyForm == null || notifyForm.IsDisposed)
            {
                notifyForm = new FormNotify();
            }
            return notifyForm;
        }
        public List<CProject> GetProjList(double notifyday)
        {
            List<CProject> projList = new List<CProject>();
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT projid,projname,createdate,projdate,finishdate,content,istop"
                + " FROM project"
                + " WHERE projdate-NOW()<" + notifyday
                + " AND isfinished=false"
                + " ORDER BY projdate DESC";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                int projid = Convert.ToInt32(thisReader["projid"].ToString());
                string projname = thisReader["projname"].ToString();
                string createdate = "";//创建日期
                string projdate = "";//事件日期
                string finishdate = "";//完成日期
                if (!thisReader.IsDBNull(2))
                {
                    createdate = thisReader.GetDateTime(2).ToString("yyyy-MM-dd HH:mm");
                }
                if (!thisReader.IsDBNull(3))
                {
                    projdate = thisReader.GetDateTime(3).ToString("yyyy-MM-dd HH:mm");
                }
                if (!thisReader.IsDBNull(4))
                {
                    finishdate = thisReader.GetDateTime(4).ToString("yyyy-MM-dd HH:mm");
                }
                bool istop = thisReader.GetBoolean(6);
                string content = thisReader["content"].ToString();
                CProject proj = new CProject(projid, projname, projdate, createdate, finishdate, content, false, istop);
                projList.Add(proj);
            }
            thisReader.Close();
            return projList;
        }
        public void Refresh(double days, string emailToAddress)
        {
            List<CProject> projList = GetProjList(days);//获取工程列表
            //1.数据为0，并且对话框为空或已关闭，则直接返回
            if (notifyForm == null || notifyForm.IsDisposed)//notifyForm为空或已关闭
            {
                //1.1窗口关闭状态下，列表为空，直接返回
                if (projList.Count == 0)
                {
                    return;
                }
                //1.2窗口关闭状态下，列表不为空，弹出窗口，刷新数据
                SetFormNotify();
                notifyForm.ProjectList = projList;
                notifyForm.Show();
            }
            else
            {
                //1.3窗口未关闭状态下，直接刷新数据
                notifyForm.ProjectList = projList;
            }
            //if (projList.Count == 0
            //    && notifyForm != null
            //    && !notifyForm.IsDisposed)
            //{
            //    notifyForm.ProjectList = projList;
            //}
            //else
            //{
            //    if (notifyForm == null || notifyForm.IsDisposed)
            //    {
            //        SetFormNotify();
            //        notifyForm.ProjectList = projList;
            //        notifyForm.Show();
            //    }
            //    else
            //    {
            //        notifyForm.ProjectList = projList;
            //    }
            //    //发送邮件
            //    if (emailToAddress != "")
            //    {
            //        string emailContent = "";
            //        int i = 1;
            //        foreach (CProject proj in projList)
            //        {
            //            emailContent += i++.ToString() + "."
            //                + proj.ProjectName + "<br/>"
            //                + "&nbsp;&nbsp;&nbsp;&nbsp;事项日期:" + proj.ProjectDate + "<br/>"
            //                + "&nbsp;&nbsp;&nbsp;&nbsp;事项内容:" + proj.Content + "<br/>";
            //        }
            //        CEmail omail = new CEmail();
            //        omail.SendMail("007xiaoming@163.com",
            //            "zbinfo",
            //            emailToAddress,
            //            "消息提醒" + DateTime.Now.ToString("yyyy/MM/dd hh:mm"),
            //            emailContent,
            //            "007xiaoming@163.com",
            //            "yihushui123",
            //            "smtp.163.com", "");
            //    }
            //}
        }
    }
}
