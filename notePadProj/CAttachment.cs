using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
namespace notePadProj
{
    public class CAttachment
    {
        private int attid;
        private string _attname;
        private string _attfilepath;
        private string _uploaddate;
        public int AttID
        {
            get
            {
                return attid;
            }
        }
        public string AttName
        {
            get
            {
                return _attname;
            }
            set
            {
                _attname = value;
            }
        }
        public string AttFilePath
        {
            get
            {
                return _attfilepath;
            }
            set
            {
                _attfilepath = value;
            }
        }
        public string UploadDate
        {
            get
            {
                return _uploaddate;
            }
            set
            {
                _uploaddate = value;
            }
        }
        public CAttachment(int attid)
        {
            this.attid = attid;
        }
        public static bool InsertAttachment(int projid, string attname, string filepath, OleDbConnection thisConn)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "INSERT INTO attachment(attname,filepath,projid)"
                + "  VALUES('" + attname + "','" + filepath + "'," + projid + ")";
            if (thisCommand.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void DeleteAttachment(OleDbConnection thisConn)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            //删除文件
            thisCommand.CommandText = "SELECT filepath FROM attachment WHERE attid=" + attid;
            string filepath = thisCommand.ExecuteScalar().ToString();
            if (System.IO.File.Exists(filepath))
            {
                System.IO.File.Delete(filepath);
            }
            //删除数据库
            thisCommand.CommandText = "DELETE * FROM attachment WHERE attid=" + attid;
            thisCommand.ExecuteNonQuery();
        }
        //public static void DeleteAttachmentByProjid(int projid, OleDbConnection thisConn)
        //{
        //    OleDbCommand thisCommand = thisConn.CreateCommand();
        //    //删除文件
        //    thisCommand.CommandText = "SELECT filepath FROM attachment WHERE projid=" + projid;
        //    OleDbDataReader thisReader = thisCommand.ExecuteReader();
        //    while (thisReader.Read())
        //    {
        //        string filepath = thisReader["filepath"].ToString();
        //        if (System.IO.File.Exists(filepath))
        //        {
        //            System.IO.File.Delete(filepath);
        //        }
        //    }
        //    thisReader.Close();
        //    //删除数据库
        //    thisCommand.CommandText = "DELETE * FROM attachment WHERE projid=" + projid;
        //    thisCommand.ExecuteNonQuery();
        //}

    }
}
