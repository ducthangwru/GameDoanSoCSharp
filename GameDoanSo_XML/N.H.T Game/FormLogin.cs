using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N.H.T_Game
{
    public partial class FormLogin : Form
    {
        Score score = new Score();

        public FormLogin()
        {
            InitializeComponent();
            MessageBoxManager.Yes = "Có";
            MessageBoxManager.No = "Không";
            MessageBoxManager.Cancel = "Hủy";
            MessageBoxManager.Register();
        }

        private void bt_easy_Click(object sender, EventArgs e)
        {
            Main main = new Main(1001, 10000, 1);
            main.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void bt_normal_Click(object sender, EventArgs e)
        {
            Main main = new Main(501, 10000, 5);
            main.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void bt_difficult_Click(object sender, EventArgs e)
        {
            Main main = new Main(251, 10000, 10);
            main.Show();
            this.Hide();
            FormState.PreviousPage = this;
        }

        private void bt_highscore_Click(object sender, EventArgs e)
        {
            if (ScoreManager.instance.loadFile() && !String.IsNullOrEmpty(ScoreManager.instance.output()))
            {
                MessageBox.Show(ScoreManager.instance.resultHighScore(), "Điểm cao");
                ScoreManager.instance.HighScore = "";
            }
            else if (ScoreManager.instance.loadFile() && ScoreManager.instance.output().Equals(""))
            {
                MessageBox.Show("Không có điểm cao nào!", "Điểm cao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đọc file!. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_history_Click(object sender, EventArgs e)
        {
            if (ScoreManager.instance.loadFile() && !String.IsNullOrEmpty(ScoreManager.instance.output()))
            {
                MessageBox.Show(ScoreManager.instance.output(), "Nhật ký chơi");
                ScoreManager.instance.Result = "";
            }
            else if (ScoreManager.instance.loadFile() && ScoreManager.instance.output().Equals(""))
            {
                MessageBox.Show("Không có nhật ký chơi", "Nhật ký chơi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể đọc file!. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_delete_history_Click(object sender, EventArgs e)
        {
            if (ScoreManager.instance.loadFile() && ScoreManager.instance.output().Equals(""))
            {
                MessageBox.Show("Không có gì để xóa!", "Xóa nhật ký", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa nhật ký?", "Xóa nhật ký",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if(dialog == DialogResult.OK)
                {
                    ScoreManager.instance.delete();
                    MessageBox.Show("Xóa nhật ký thành công!", "Xóa nhật ký",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa nhật ký thất bại!", "Xóa nhật ký",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
            }
        }

        private void bt_guild_Click(object sender, EventArgs e)
        {
            try
            {
                string lines = System.IO.File.ReadAllText("data/huongdan.txt");
                MessageBox.Show(lines, "Hướng dẫn chơi", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Không thể đọc file. Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thoát",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(dialog == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void bt_facebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thang.jurle");
        }

        private void bt_report_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            FormState.PreviousPage = this;
            SendEmail sendEmail = new SendEmail();
            sendEmail.Show();
        }
    }
}
