using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;
using System.Timers;
using System.Xml;
using System.Windows.Forms;

namespace 邮件发送器
{
    class Email
    {
        /// <summary>
        /// 发送邮件
        /// subject邮件主题
        /// body邮件正文
        /// userName = "your email";  发送端账号   
        ///password = "the password of your email";  发送端密码
        ///host = "smtp.126.com";  邮件服务器smtp.163.com表示网易邮箱服务器  
        ///file附件
        /// </summary>
        public static void SendEmail(string subject, string body,string sendto , string file=null, string userName = "username[待替换]", string password = "password[待替换]", string sendcopyto=null, string sendername="a_flying_fish", string host = "smtp.126.com")
        {
            System.Net.Mail.SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式    
            client.Host = host;//邮件服务器
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(userName, password);//用户名、密码

            //////////////////////////////////////
            //string strfrom = userName;

            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage();
            msg.From = new MailAddress(userName, sendername);
            if(sendto[sendto.Length-1]!='m'|| sendto[sendto.Length - 2]!='o'|| sendto[sendto.Length - 3] != 'c'|| sendto[sendto.Length - 4] != '.')
            {
                MessageBox.Show("请确认您的邮箱格式正确");
                return;       
            }//填写的邮箱没有基本问题
            msg.To.Add(sendto);//发送给XXX
            if (sendcopyto != null)
            {
                msg.CC.Add(sendcopyto);//抄送
            }
            msg.Subject = subject;//邮件标题   
            msg.Body = body;//邮件内容   
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码   
            msg.IsBodyHtml = true;//是否是HTML邮件   
            msg.Priority = MailPriority.Low;//邮件优先级 
            if(file!=""&&File.Exists(file)==false)
            {
                MessageBox.Show("请确定附件路径存在且不是文件夹，或者不是全为空格");
                return;
            }
            if (file != "")
            {
                msg.Attachments.Add(new Attachment(file));
            }

            try
            {
                client.Send(msg);
                Console.WriteLine("发送成功");
                MessageBox.Show("发送成功");
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                Console.WriteLine(ex.Message, "发送邮件出错");
                MessageBox.Show("请检查邮箱地址是否正确，电脑远程端口:25 是否开启，或者对方是否开通该邮箱");
            }
        }

    }
}