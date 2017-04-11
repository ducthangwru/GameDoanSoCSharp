using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N.H.T_Game
{
    public partial class FormSaveScore : Form
    {
        private int score;
        private int levelInt;
        private string level;
       
        Score scores;

        public FormSaveScore(int score, int level)
        {
            InitializeComponent();
            this.score = score;
            this.levelInt = level;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            saveScore();
        }

        public void saveScore()
        {
            if(String.IsNullOrEmpty(tb_save.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                switch(levelInt)
                {
                    case 1:
                        level = "Chế độ Dễ";
                        break;
                    case 5:
                        level = "Chế độ Trung Bình";
                        break;
                    case 10:
                        level = "Chế độ Khó";
                        break;
                }

                if(ScoreManager.instance.loadFile())
                {
                    scores = new Score();
                    scores.Level = level;
                    scores.Name = tb_save.Text;
                    scores.Score1 = score;
                    scores.DateTime = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
                    if (ScoreManager.instance.add(scores))
                    {
                        MessageBox.Show("Lưu thành công!", "Lưu điểm",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Không thể lưu điểm!", "Lưu điểm", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
               
                //try
                //{
                //    connect.Open();
                //    Console.WriteLine(level);
                //    string sql = "insert into NhatKyDiem values(N'"+ level + "',N'"
                //        + tb_save.Text + "',"
                //        + score + ",'" +
                //        DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt", CultureInfo.InvariantCulture) + "')";

                //    Console.WriteLine(sql);
                //    SqlCommand sqlcom = new SqlCommand(sql, connect);
                //    sqlcom.ExecuteNonQuery();
                    
                //    DialogResult dialog = MessageBox.Show("Lưu thành công!", "Lưu điểm", MessageBoxButtons.OK);

                //    if (dialog == DialogResult.OK || dialog == DialogResult.Cancel)
                //    {
                //        this.Close();
                //    }
                //}
                //catch
                //{
                //    MessageBox.Show("Không thêm được!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    this.Close();
                //}
                //finally
                //{
                //    SqlConnection connect = new SqlConnection
                //    (ConfigurationManager.ConnectionStrings["QLDiemConnectionString"].ConnectionString);
                //    connect.Close();
                //    this.Close();
                //}
            }
        }

        private void tb_save_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                saveScore();
            }
        }
    }
}
