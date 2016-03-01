using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
//MD5
using System.Security.Cryptography;//MD5
//using System.Configuration;
namespace notePadProj
{
    class CUser
    {
        private string name;//用户名称
        public CUser(string name)
        {
            this.name = name;
        }
        public string GetPasswordFromDB(OleDbConnection thisConn)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT userpassword FROM tbuser WHERE username='" + name + "'";
            string password = thisCommand.ExecuteScalar().ToString();
            return password;
        }
        /// <summary>
        /// 对input进行MD5加密
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string getMd5Hash(string input)
        {
            // Create a new instance of the MD5CryptoServiceProvider object.
            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(System.Text.Encoding.Default.GetBytes(input + "k4"));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            // Return the hexadecimal string.
            return sBuilder.ToString();
        }
        /// <summary>
        /// 比较input进行加密之后与hash是否一致
        /// </summary>
        /// <param name="input">输入密码</param>
        /// <param name="hash">数据库存储密码</param>
        /// <returns></returns>
        public static bool verifyMd5Hash(string input, string hash)
        {
            // Hash the input.
            string hashOfInput = getMd5Hash(input);
            // Create a StringComparer an comare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 对用户信息进行更新
        /// </summary>
        /// <param name="username">用户姓名(主键)</param>
        /// <param name="email">用户email</param>
        /// <param name="password">密码</param>
        /// <param name="isRemepass">是否记住密码</param>
        /// <param name="isAutoLogin">是否自动登录</param>
        /// <returns></returns>
        public bool UpdateUserInfo(string email, string password, bool isRemepass, bool isAutoLogin, OleDbConnection thisConn)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            string newpass = CUser.getMd5Hash(password);
            string ispassRem = isRemepass ? "true" : "false";
            string isautoLogin = isAutoLogin ? "true" : "false";
            thisCommand.CommandText = "UPDATE tbuser SET email='" + email + "'"
                + ",userpassword='" + newpass + "'"
                + ",remepass=" + ispassRem
                + ",autologin=" + isautoLogin
                + " WHERE username='" + name + "'";
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
        /// 用户登录时，更新用户的记住密码及自动登陆信息
        /// </summary>
        /// <param name="isRemepass"></param>
        /// <param name="isAutoLogin"></param>
        /// <param name="thisConn"></param>
        public void UpdateUserLoginInfo(bool isRemepass, bool isAutoLogin, OleDbConnection thisConn)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            string ispassRem = isRemepass ? "true" : "false";
            string isautoLogin = isAutoLogin ? "true" : "false";
            thisCommand.CommandText = "UPDATE tbuser SET remepass=" + ispassRem
                + ",autologin=" + isautoLogin
                + " WHERE username='" + name + "'";
            thisCommand.ExecuteNonQuery();
        }

        public bool IsUserExist(OleDbConnection thisConn)
        {
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "SELECT COUNT(*) FROM tbuser WHERE username='" + name + "'";
            //thisCommand.CommandText = "SELECT * FROM tbuser";
            int count = Convert.ToInt32(thisCommand.ExecuteScalar().ToString());
            if (count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更改数据库密码
        /// </summary>
        public void UpdateDBPassword()
        {

        }

    }
}
