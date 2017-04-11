using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace N.H.T_Game
{
    public partial class SendEmail : Form
    {
        private string emailAddress = "ducthangwru97@gmail.com";
        Attachment attach = null;
        public SendEmail()
        {
            MessageBox.Show("Hướng dẫn:\n Vào trang: https://myaccount.google.com/lesssecureapps chọn Bật. \n Nhấn OK để bắt đầu gửi phản hồi",
                "Hướng dẫn gửi mail", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();
            lb_report.Text = "Hướng dẫn:\nVào trang: https://myaccount.google.com/lesssecureapps \nchọn Bật.";
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(tb_title.Text) || String.IsNullOrEmpty(tb_content.Text))
            {
                MessageBox.Show("Có trường đang để trống! Vui lòng điền đầy đủ nội dung", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bt_send.Enabled = false;
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(tb_filename.Text);
                    attach = new Attachment(tb_filename.Text);
                }
                catch { }

                Send(tb_username.Text, emailAddress, tb_title.Text, tb_content.Text, attach);
            }
        }

        private void bt_choose_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if(openFile.ShowDialog() == DialogResult.OK)
            {
                tb_filename.Text = openFile.FileName;
            }
        }

        public void Send(string from, string to, string title, string content, Attachment file = null)
        {
            try
            {
                MailMessage mess = new MailMessage(from, to, title, content);

                if(attach != null)
                {
                    mess.Attachments.Add(attach);
                }

                SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //gửi mail
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(tb_username.Text, tb_password.Text);
                client.Send(mess);
                MessageBox.Show("Gửi mail thành công!");
            }
            catch(FormatException)
            {
                MessageBox.Show("Email không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(SmtpException)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bt_send.Enabled = true;
            }
        }

        private void SendEmail_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormState.PreviousPage.Enabled = true;
            e.Cancel = false;
        }
    }
}
