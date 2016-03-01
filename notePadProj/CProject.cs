using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.IO;
namespace notePadProj
{
    public class CProject
    {
        private int projID;
        private OleDbConnection thisConn;
        public int ProjectID
        {
            get
            {
                return projID;
            }
        }
        public CProject(int projID, OleDbConnection thisConn)
        {
            this.projID = projID;
            this.thisConn = thisConn;
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT projname,createdate,projdate,finishdate,content,isfinished,istop"
                     + " FROM project WHERE projid= " + projID;
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            if (thisReader.Read())
            {
                string projname = thisReader["projname"].ToString();
                string createdate = "";//创建日期
                string projdate = "";//事件日期
                string finishdate = "";//完成日期
                if (!thisReader.IsDBNull(1))
                {
                    createdate = thisReader.GetDateTime(1).ToString("yyyy-MM-dd HH:mm");
                }
                if (!thisReader.IsDBNull(2))
                {
                    projdate = thisReader.GetDateTime(2).ToString("yyyy-MM-dd HH:mm");
                }
                if (!thisReader.IsDBNull(3))
                {
                    finishdate = thisReader.GetDateTime(3).ToString("yyyy-MM-dd HH:mm");
                }
                string content = thisReader["content"].ToString();
                bool isfinished = thisReader.GetBoolean(5);
                bool istop = thisReader.GetBoolean(6);
                this._projname = projname;
                this._projdate = projdate;
                this._createdate = createdate;
                this._finishdate = finishdate;
                this._content = content;
                this._isfinished = isfinished;
                this._istop = istop;
            }
            thisReader.Close();
        }

        public CProject(int projID, string projname, string projdate, string createdate, string finishdate, string content, bool isfinished, bool istop)
        {
            this.projID = projID;
            this._projname = projname;
            this._projdate = projdate;
            this._createdate = createdate;
            this._finishdate = finishdate;
            this._content = content;
            this._isfinished = isfinished;
            this._istop = istop;
        }


        /// <summary>
        /// 新增一条记录
        /// </summary>
        /// <param name="projname"></param>
        /// <param name="content"></param>
        /// <param name="thisconn"></param>
        /// <returns></returns>
        public static int InsertProj(string projname, string content, string projdate, bool istop, OleDbConnection thisconn)
        {
            int projid = 0;
            string istopstr = istop ? "TRUE" : "FALSE";
            OleDbCommand thisCommand = thisconn.CreateCommand();
            thisCommand.CommandText = "INSERT INTO project(projname,content,projdate,istop) "
                + " VALUES('" + projname + "','" + content + "'," + projdate + "," + istopstr + ")";
            thisCommand.ExecuteNonQuery();
            thisCommand.CommandText = "SELECT MAX(projid) FROM project";
            projid = Convert.ToInt32(thisCommand.ExecuteScalar());
            return projid;
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="projname"></param>
        /// <param name="content"></param>
        /// <param name="isFinished"></param>
        /// <param name="thisconn"></param>
        /// <returns></returns>
        public bool UpdateProj(string projname, string content, string projdate, bool isFinished,bool isTop)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT isfinished FROM project WHERE projid=" + projID;
            bool isOldFinished;
            object result = thisCommand.ExecuteScalar();//返回的结果值
            if (result == null)
            {
                isOldFinished = false;
            }
            else
            {
                isOldFinished = Convert.ToBoolean(result);
            }
            string finishDateStr = "";//完成日期更新字符串
            //如果原来已完成，并且更改为未完成，将完成日期清空
            if (isOldFinished == true && isFinished == false)
            {
                finishDateStr = ",finishdate=null";
            }
            else if (isOldFinished == false && isFinished == true)
            {
                //如果原来未完成，更改为已完成，赋为当前日期
                finishDateStr = ",finishdate=Now()";
            }
            string finishStr = isFinished ? "true" : "false";//是否已经完成
            string topstr = isTop ? "true" : "false";//是否置顶
            thisCommand.CommandText = "UPDATE project "
                + " SET projname='" + projname + "'"
                + ",content='" + content + "'"
                + ",projdate=" + projdate + ""
                + ",isfinished=" + finishStr
                + ",istop=" + topstr
                + finishDateStr
                + " WHERE projid=" + projID;
            if (thisCommand.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新记录状态
        /// </summary>
        /// <param name="isFinished">是否完成</param>
        /// <param name="thisConn"></param>
        /// <returns></returns>
        public bool UpdateProjStatus(bool isFinished)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            string finishStr = isFinished ? "true" : "false";//是否已经完成
            string finishDateStr = "";
            if (isFinished)
            {
                finishDateStr = ",finishdate=Now()";
            }
            else
            {
                finishDateStr = ",finishdate=null";
            }
            thisCommand.CommandText = "UPDATE project "
                + " SET isfinished=" + finishStr
                + finishDateStr
                + " WHERE projid=" + projID;
            if (thisCommand.ExecuteNonQuery() > 0)
            {
                //更新对象状态
                this._isfinished = isFinished;
                thisCommand.CommandText = "SELECT finishdate FROM project WHERE projid=" + this.projID;
                OleDbDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    if (thisReader.IsDBNull(0))
                    {
                        this._finishdate = "";
                    }
                    else
                    {
                        this._finishdate = thisReader.GetDateTime(0).ToString("yyyy-MM-dd HH:mm");
                    }
                }
                thisReader.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 更新记录状态
        /// </summary>
        /// <param name="istop">是否置顶</param>
        /// <returns></returns>
        public bool UpdateProjTop(bool istop)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            string topStr = istop ? "true" : "false";//是否已经完成
            thisCommand.CommandText = "UPDATE project "
                + " SET istop=" + topStr
                + " WHERE projid=" + projID;
            if (thisCommand.ExecuteNonQuery() > 0)
            {
                //更新对象状态
                this._istop = istop;
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <param name="thisconn"></param>
        /// <returns></returns>
        public bool DeleteProj()
        {
            OleDbCommand thisCommand = this.thisConn.CreateCommand();
            thisCommand.CommandText = "DELETE * FROM project WHERE projid=" + projID;
            if (thisCommand.ExecuteNonQuery() > 0)
            {
                //1.删除附件
                string projFolder = System.Windows.Forms.Application.StartupPath + "\\data\\fujian\\" + projID;
                if (Directory.Exists(projFolder))
                {
                    DirectoryInfo di = new DirectoryInfo(projFolder);
                    di.Delete(true);
                }
                //2.删除数据库
                thisCommand.CommandText = "DELETE * FROM attachment WHERE projid=" + projID;
                thisCommand.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }

        private string _projname;
        public string ProjectName
        {
            get
            {
                return _projname;
            }
            set
            {
                _projname = value;
            }
        }
        private string _createdate;
        public string CreateDate
        {
            get
            {
                return _createdate;
            }
            set
            {
                _createdate = value;
            }
        }
        private string _projdate;
        public string ProjectDate
        {
            get
            {
                return _projdate;
            }
            set
            {
                _projdate = value;
            }
        }
        private string _finishdate;
        public string FinishDate
        {
            get
            {
                return _finishdate;
            }
            set
            {
                _finishdate = value;
            }
        }
        private string _content;
        public string Content
        {
            get
            {
                return _content;
            }
            set
            {
                _content = value;
            }
        }
        private bool _isfinished;
        public bool IsFinished
        {
            get
            {
                return _isfinished;
            }
            set
            {
                _isfinished = value;
            }
        }
        /// <summary>
        /// 是否置顶
        /// </summary>
        private bool _istop;
        public bool IsTop
        {
            get
            {
                return _istop;
            }
            set
            {
                _istop = value;
            }
        }
        /// <summary>
        /// 根据关键词，返回工程列表
        /// </summary>
        /// <param name="keywords"></param>
        public static List<CProject> GetProjList(string keyword, OleDbConnection thisConn)
        {
            List<CProject> projList = new List<CProject>();
            OleDbCommand thisCommand = thisConn.CreateCommand();
            if (keyword == "")
            {
                thisCommand.CommandText = "SELECT projid"
                    + " FROM project ORDER BY isfinished DESC,projdate ";
            }
            else
            {
                thisCommand.CommandText = "SELECT projid"
                    + " FROM project"
                    + " WHERE projname LIKE '%" + keyword + "%'"
                    + " OR content LIKE '%" + keyword + "%'"
                    + " ORDER BY isfinished DESC,projdate ";
            }
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            List<int> projIDList = new List<int>();
            while (thisReader.Read())
            {
                int projid = Convert.ToInt32(thisReader["PROJID"]);
                projIDList.Add(projid);
            }
            thisReader.Close();
            foreach (int projid in projIDList)
            {
                projList.Add(new CProject(projid, thisConn));
            }
            return projList;
        }
        public List<CAttachment> GetAttList()
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT attid,attname,uploaddate,filepath,beizhu"
                           + " FROM attachment WHERE projid=" + projID;
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            List<CAttachment> attList = new List<CAttachment>();
            while (thisReader.Read())
            {
                int attid = Convert.ToInt32(thisReader["attid"]);
                string attname = thisReader["attname"].ToString();
                string uploaddate = "";
                if (!thisReader.IsDBNull(2))
                {
                    uploaddate = thisReader.GetDateTime(2).ToString("yyyy-MM-dd HH:mm");
                }
                string filepath = thisReader["filepath"].ToString();
                string beizhu = thisReader["beizhu"].ToString();
                CAttachment att = new CAttachment(attid);
                att.AttName = attname;
                att.UploadDate = uploaddate;
                att.AttFilePath = filepath;
                attList.Add(att);
            }
            thisReader.Close();
            return attList;
        }
        public static List<CProject> GetProjListByCondition(string keyword,
            string dateType,
            string beginDate,
            string endDate,
            string finishStatus,
            OleDbConnection thisConn)
        {
            List<CProject> projList = new List<CProject>();
            string conditionStr = "";//条件语句
            string sqlKeyword = " WHERE ";//SQL语句连接词，用以区分是 where 还是 and 
            //1.关键词
            if (keyword != "")
            {
                conditionStr = sqlKeyword + " (projname LIKE '%" + keyword + "%'"
                    + " OR content LIKE '%" + keyword + "%')";
                sqlKeyword = " AND ";
            }
            //2.是否完成
            if (finishStatus == "已完成")
            {
                conditionStr += sqlKeyword + " isfinished=TRUE ";
                sqlKeyword = " AND ";
            }
            else if (finishStatus == "未完成")
            {
                conditionStr += sqlKeyword + " isfinished=FALSE ";
                sqlKeyword = " AND ";
            }
            //3.日期语句
            if (dateType != "")
            {
                string dateTypeStr = "";
                switch (dateType)
                {
                    case "事项日期":
                        dateTypeStr = " projdate ";
                        break;
                    case "创建日期":
                        dateTypeStr = " createdate ";
                        break;
                    case "完成日期":
                        dateTypeStr = " finishdate ";
                        break;
                    default:
                        break;
                }
                if (beginDate != "")
                {
                    conditionStr += sqlKeyword + dateTypeStr + " >=#" + beginDate + "#";
                    sqlKeyword = " AND ";
                }
                //4.结束日期
                if (endDate != "")
                {
                    conditionStr += sqlKeyword + dateTypeStr + "<=#" + endDate + "#";
                }
            }
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT projid,projname,createdate,projdate,finishdate,content,isfinished,istop"
                + " FROM project"
                + conditionStr
                + " ORDER BY istop,isfinished DESC,projdate DESC,createdate DESC";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                int projid = Convert.ToInt32(thisReader["projid"]);
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
                string content = thisReader["content"].ToString();
                bool isfinished = thisReader.GetBoolean(6);
                bool istop = thisReader.GetBoolean(7);
                CProject proj = new CProject(projid, projname, projdate, createdate, finishdate, content, isfinished, istop);
                projList.Add(proj);
            }
            thisReader.Close();
            return projList;
        }
    }
}