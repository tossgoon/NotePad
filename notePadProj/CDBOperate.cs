using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;
namespace notePadProj
{
    /// <summary>
    /// 关于数据库的操作，更改数据库密码
    /// </summary>
    class CDBOperate
    {
        /// <summary>
        /// 从根目录\data\setting.txt中读取密码
        /// </summary>
        /// <returns></returns>
        public static string GetDBPasswordFromTxt()
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\data\\setting.txt";
            string passwordstr = "";
            if (File.Exists(txtFilePath))
            {
                FileStream aFile = new FileStream(txtFilePath, FileMode.Open);
                StreamReader sr = new StreamReader(aFile);
                passwordstr = sr.ReadLine();
                sr.Close();
                aFile.Close();
                sr.Dispose();
                aFile.Dispose();
            }
            if (passwordstr != "")
            {
                //还原密码
                //每三个字符为对应一个密码字符
                List<string> strList = new List<string>();
                string str = "";
                for (int i = 0; i < passwordstr.Length; i++)
                {
                    if (i > 0 && i % 3 == 0)
                    {
                        strList.Add(str.TrimStart(new char[] { '0' }));
                        str = "";
                    }
                    str += passwordstr[i];
                    if (i == passwordstr.Length - 1)
                    {
                        strList.Add(str);
                    }
                }
                //对字符串进行变换
                List<byte> byteList = new List<byte>();
                foreach (string astr in strList)
                {
                    byteList.Add(Convert.ToByte(astr));
                }
                passwordstr = System.Text.Encoding.ASCII.GetString(byteList.ToArray());
                //倒序输出
                string result = "";
                for (int i = passwordstr.Length - 1; i >= 0; i--)
                {
                    result += passwordstr[i];
                }
                passwordstr = result;
            }
            return passwordstr;
        }
        /// <summary>
        /// 将新密码进行加密后，写入配置文件
        /// </summary>
        /// <param name="newPassWord"></param>
        /// <returns></returns>
        public static bool WriteDBPassword2Txt(string newPassWord)
        {
            string filePath = System.Windows.Forms.Application.StartupPath + "\\data\\setting.txt";
            if (!File.Exists(filePath))
            {
                FileStream fs = File.Create(filePath);
                fs.Close();
            }
            try
            {
                FileStream aFile = new FileStream(filePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(aFile);
                //新密码
                string passJiaMi = "";
                //1.倒序
                for (int i = newPassWord.Length - 1; i >= 0; i--)
                {
                    passJiaMi += newPassWord[i];
                }
                //2.转换为ASCII数组，并且左边补0为3位
                byte[] bytes = System.Text.Encoding.ASCII.GetBytes(passJiaMi);
                string result = "";
                for (int i = 0; i < bytes.Length; i++)
                {
                    string s = bytes[i].ToString().PadLeft(3, '0');
                    result += s;
                }
                sw.WriteLine(result);
                sw.Close();
                aFile.Close();
                sw.Dispose();
                aFile.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static OleDbConnection GetConnection()
        {
            string mdbFile = System.Windows.Forms.Application.StartupPath + "\\data\\notepad.mdb";
            if (!File.Exists(mdbFile))
            {
                CreateMdbFile(mdbFile);//数据库文件不存在则创建一个
            }
            string password = GetDBPasswordFromTxt();
            string connectStr = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=";
            connectStr += mdbFile + ";Jet OLEDB:Database Password=" + password;
            OleDbConnection thisConn = new OleDbConnection(connectStr);
            return thisConn;
        }
        /// <summary>
        /// 从资源文件里提取notepad.mdb文件，复制到../data/中
        /// </summary>
        /// <param name="fileName"></param>
        private static bool CreateMdbFile(string fileName)
        {
            try
            {
                byte[] modal = notePadProj.Properties.Resources.notepad;
                MemoryStream m = new MemoryStream(modal);
                FileStream fs = new FileStream(fileName, FileMode.Create);
                m.WriteTo(fs);
                m.Close();
                fs.Close();
                m = null;
                fs = null;
                //初始化设置的密码
                WriteDBPassword2Txt("db1");
                return true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void CreateWordModalFile(string fileName)
        {
            try
            {
                byte[] modal = notePadProj.Properties.Resources.DataModel;
                MemoryStream m = new MemoryStream(modal);
                FileStream fs = new FileStream(fileName, FileMode.Create);
                m.WriteTo(fs);
                m.Close();
                fs.Close();
                m = null;
                fs = null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }
    }
}
