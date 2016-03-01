using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
namespace notePadProj
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLogin();
        }
        private void UserLogin()
        {
            //1.完整性判断
            //判断用户名是否存在
            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名");
                return;
            }
            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("请输入密码");
                return;
            }
            //2.数据库连接
            //判断文件是否存在
            OleDbConnection thisConn = CDBOperate.GetConnection();
            try
            {
                thisConn.Open();
                CUser user = new CUser(txtUserName.Text);
                if (!user.IsUserExist(thisConn))
                {
                    MessageBox.Show("用户不存在");
                    return;
                }
                string password = user.GetPasswordFromDB(thisConn);
                if (CUser.verifyMd5Hash(txtPassword.Text, password))
                {
                    //user.UpdateUserLoginInfo(chkRemePass.Checked, chkAutoLogin.Checked, thisConn);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("密码错误");
                    txtPassword.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接错误：" + ex.Message);
            }
            finally
            {
                if (thisConn.State == ConnectionState.Open)
                {
                    thisConn.Close();
                }
            }
        }
        private void linkLbDBSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSetting form = new FormSetting();
            form.ShowDialog();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserLogin();
            }
        }
    }
}
