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
    public partial class FormSetting : Form
    {
        private OleDbConnection thisConn;
        public delegate void updateNotifyHandler(double notifyDays, double refreshHours, string email
            , string sendemail, string sendemailpassword, string sendemailserver);
        public event updateNotifyHandler eventUpdateNotify;//自定义更新事件
        public FormSetting()
        {
            InitializeComponent();
            //
            gboxNotify.Enabled = false;
            gboxUserPassword.Enabled = false;
        }
        public FormSetting(double notifyDays, double refreshHours, string emailAddress, string sendemail, string sendemailpassword, string sendemailserver, OleDbConnection thisConn)
        {
            InitializeComponent();
            txtNotifyDays.Text = notifyDays.ToString();
            txtRefreshTime.Text = refreshHours.ToString();
            txtEmail.Text = emailAddress;
            txtSendEmail.Text = sendemail;
            txtSendEmailPassword.Text = sendemailpassword;
            txtSendEmailServer.Text = sendemailserver;
            this.thisConn = thisConn;
        }
        /// <summary>
        /// 提醒设置更改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //判断天数为正整数
            double days = 0;
            if (double.TryParse(txtNotifyDays.Text, out days))
            {
                if (days < 0)
                {
                    MessageBox.Show("天数小于0，请重输");
                    return;
                }
            }
            else
            {
                MessageBox.Show("提醒天数出错");
                return;
            }
            //判断刷新时间
            double hours = 0;
            if (double.TryParse(this.txtRefreshTime.Text, out hours))
            {
                if (hours < 0)
                {
                    MessageBox.Show("刷新时间小于0，请重输");
                    return;
                }
            }
            else
            {
                MessageBox.Show("刷新时间出错");
                return;
            }
            //判断email格式
            if (txtEmail.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    MessageBox.Show("接收邮箱格式出错");
                    return;
                }
            }
            //判断email格式
            if (txtSendEmail.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(this.txtSendEmail.Text, @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"))
                {
                    MessageBox.Show("发送邮箱格式出错");
                    return;
                }
            }
            //更新数据库
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "UPDATE setting SET sysvalue='" + days + "'"
                + " WHERE syskey='notifyday'";
            thisCommand.ExecuteNonQuery();
            thisCommand.CommandText = "UPDATE setting SET sysvalue='" + hours + "'"
                + " WHERE syskey='refreshhour'";
            thisCommand.ExecuteNonQuery();
            thisCommand.CommandText = "UPDATE tbuser SET email='" + txtEmail.Text + "'"
                + " WHERE username='admin'";
            thisCommand.ExecuteNonQuery();
            //更新发送邮箱
            //发送邮箱
            thisCommand.CommandText = "SELECT COUNT(*) FROM setting WHERE syskey='sendemail'";
            if (Convert.ToInt32(thisCommand.ExecuteScalar()) > 0)
            {
                thisCommand.CommandText = "UPDATE setting SET sysvalue='" + txtSendEmail.Text + "'"
                + " WHERE syskey='sendemail'";
            }
            else
            {
                thisCommand.CommandText = "INSERT INTO setting(syskey,sysvalue)"
                    + " VALUES ('sendemail','" + txtSendEmail.Text + "')";
            }
            thisCommand.ExecuteNonQuery();
            //发送邮箱密码
            thisCommand.CommandText = "SELECT COUNT(*) FROM setting WHERE syskey='sendemailpass'";
            if (Convert.ToInt32(thisCommand.ExecuteScalar()) > 0)
            {
                thisCommand.CommandText = "UPDATE setting SET sysvalue='" + txtSendEmailPassword.Text + "'"
                + " WHERE syskey='sendemailpass'";
            }
            else
            {
                thisCommand.CommandText = "INSERT INTO setting(syskey,sysvalue)"
                    + " VALUES ('sendemailpass','" + txtSendEmailPassword.Text + "')";
            }
            thisCommand.ExecuteNonQuery();
            //发送邮箱服务器
            thisCommand.CommandText = "SELECT COUNT(*) FROM setting WHERE syskey='emailserver'";
            if (Convert.ToInt32(thisCommand.ExecuteScalar()) > 0)
            {
                thisCommand.CommandText = "UPDATE setting SET sysvalue='" + this.txtSendEmailServer.Text + "'"
                + " WHERE syskey='emailserver'";
            }
            else
            {
                thisCommand.CommandText = "INSERT INTO setting(syskey,sysvalue)"
                    + " VALUES ('emailserver','" + txtSendEmailServer.Text + "')";
            }
            thisCommand.ExecuteNonQuery();
            //设置主窗口数据
            eventUpdateNotify(days, hours, txtEmail.Text, txtSendEmail.Text, txtSendEmailPassword.Text, txtSendEmailServer.Text);
            MessageBox.Show("√更新完成");
        }

        private void btnPasswordSet_Click(object sender, EventArgs e)
        {
            //1.判断旧密码是否正确
            CUser user = new CUser("admin");
            if (!user.IsUserExist(thisConn))
            {
                MessageBox.Show("用户不存在");
                return;
            }
            string password = user.GetPasswordFromDB(thisConn);
            if (!CUser.verifyMd5Hash(txtOldPassword.Text, password))
            {
                MessageBox.Show("旧密码输入错误");
                return;
            }
            if (txtNewPassword.Text != txtNewPassword2.Text)
            {
                MessageBox.Show("新密码输入不一致");
                return;
            }
            //更新密码
            string newPassword = CUser.getMd5Hash(txtNewPassword.Text);
            OleDbCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = "UPDATE tbuser SET userpassword='" + newPassword + "'"
                + " WHERE username='admin'";
            thisCommand.ExecuteNonQuery();
            //更新数据库密码
            //CDBOperate.UpdateDBAndTxtPassword(thisConn, txtNewPassword.Text);
            MessageBox.Show("√更新完成");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDBPasswordSet_Click(object sender, EventArgs e)
        {
            if (txtDBNewPasswrod1.Text == "")
            {
                MessageBox.Show("密码为空，请重输。");
                return;
            }
            if (txtDBNewPasswrod1.Text != txtDBNewPasswrod2.Text)
            {
                MessageBox.Show("两次密码不一致，请重输。");
                return;
            }
            //判断旧的密码
            string oldDBPassword = CDBOperate.GetDBPasswordFromTxt();
            if (oldDBPassword != txtDBOldPasswrod.Text)
            {
                MessageBox.Show("旧密码输入错误，请重输");
                return;
            }
            //更新新密码
            if (CDBOperate.WriteDBPassword2Txt(txtDBNewPasswrod1.Text))
            {
                MessageBox.Show("数据库密码在程序中设置成功。请手动更改access数据库打开密码。");
            }
        }

        private void linkSendEmail_MouseEnter(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "发送邮箱说明";
            //this.toolTip1.UseFading = true;
            //this.toolTip1.IsBalloon = true;
            this.toolTip1.Show("发送邮箱必须开通 POP3/SMTP 服务。163邮箱服务器为：smtp.163.com  机勘院邮箱为:mail.jk.com.cn", this.linkSendEmail);
        }

        private void linkSendEmail_MouseLeave(object sender, EventArgs e)
        {
            this.toolTip1.Hide(linkSendEmail);
        }
    }
}
