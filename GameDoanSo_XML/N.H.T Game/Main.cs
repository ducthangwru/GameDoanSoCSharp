using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N.H.T_Game
{
    public partial class Main : Form
    {
        private int timeCount;
        private int time;
        private int range;
        private int number;
        private int score;
        private int coefficient;
        private int textResult;
        private bool isExit = false;

        public Main(int time, int range,int coefficient)
        {
            InitializeComponent();

            this.timeCount = time;
            this.time = time;
            this.range = range;
            this.coefficient = coefficient;

            randomNumber();
            lb_time.Text = "" + timeCount / 10;

            if(coefficient == 20)
            {
                timerRandom.Enabled = true;
            }

            timerTick.Enabled = true;
            timerTick.Start();
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            timeCount--;
            if(timeCount % 10 == 0)
            {
                lb_time.Text = "" + timeCount / 10;
            }

            if(timeCount < 0 || textResult == -1)
            {
                timeCount = -1;
                timerTick.Stop();
                lb_sussgest.Text = "Bạn đã thua!";
                DialogResult dialog = MessageBox.Show("Bạn đã thua!", "Game Over",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(dialog == DialogResult.OK)
                {
                    saveScore();
                }
            }
        }

        private void randomNumber()
        {
            Random rnd = new Random();
            number = rnd.Next(0, range);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (!int.TryParse(tb_value.Text, out textResult))
                {
                    MessageBox.Show("Bạn hãy nhập số trong khoảng (0 ->  2,147,483,647)", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    textResult = Int32.Parse(tb_value.Text);
                    Console.WriteLine(textResult + " " + number);
                    if (textResult > number)
                    {
                        lb_sussgest.Text = "Gợi ý: " + textResult + " lớn hơn ";
                    }
                    else if (textResult < number)
                    {
                        lb_sussgest.Text = "Gợi ý: " + textResult + " nhỏ hơn ";
                    }
                    else if (textResult == -1)
                    {
                        lb_sussgest.Text = "Bạn đã thua!";
                    }
                    else
                    {
                        timerTick.Stop();
                        lb_random_number.Text = number.ToString();
                        score += (timeCount / 10 * coefficient);
                        lb_score.Text = "" + score;
                        lb_sussgest.Text = "Chính xác!";

                        MessageBox.Show("Bạn đoán chính xác. Bạn được thêm " + score + " Điểm ", "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        DialogResult dialog = MessageBox.Show("Bạn có muốn chơi tiếp không?", "Chơi tiếp",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if(dialog == DialogResult.Yes)
                        {
                            lb_sussgest.Text = "";
                            lb_random_number.Text = "..........";
                            timeCount = time;
                            timerTick.Start();
                            randomNumber();
                        }
                        else
                        {
                            saveScore();
                        }
                    }
                }
                tb_value.Text = "";
            }
        }

        private void bt_pause_Click(object sender, EventArgs e)
        {
            pauseGame();
        }

        private void bt_backmenu_Click(object sender, EventArgs e)
        {
            saveScore();
        }

        public void saveScore()
        {
            if(score > 0)
            {
                DialogResult dialogSave = MessageBox.Show("Bạn có muốn lưu điểm không?", "Lưu Điểm",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogSave == DialogResult.Yes)
                {
                    this.Hide();
                    FormState.PreviousPage.Show();
                    FormState.PreviousPage = this;
                    FormSaveScore formSave = new FormSaveScore(score, coefficient);
                    formSave.Show();
                }
                else
                {
                    MessageBox.Show("Bạn chưa lưu điểm!", "Lưu điểm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isExit = true;
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        public void pauseGame()
        {
            timerTick.Stop();
            DialogResult dialog = MessageBox.Show(
                "Nhấn OK để tiếp tục!", "Tạm dừng", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(dialog == DialogResult.OK)
            {
                timerTick.Start();
            }
        }


        public void reset()
        {
            timerTick.Start();
            lb_random_number.Text = "..........";
            score = 0;
            lb_score.Text = "00";
            timeCount = time;
        }

        private void mi_newgame_Click(object sender, EventArgs e)
        {
            timerTick.Stop();
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn chơi mới không?", "Chơi mới",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                reset();
            }
            else
            {
                timerTick.Start();
            }
        }

        private void mi_savescore_Click(object sender, EventArgs e)
        {
            timerTick.Stop();
            if(score <= 0)
            {
                MessageBox.Show("Điểm quá thấp! Không thể lưu!", "Lưu điểm",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            saveScore();
        }

        private void mi_backMenu_Click(object sender, EventArgs e)
        {
            saveScore();
        }

        private void mi_quitGame_Click(object sender, EventArgs e)
        {
            saveScore();
        }

        private void mi_pause_Click(object sender, EventArgs e)
        {
            pauseGame();
        }

        private void mi_guilde_Click(object sender, EventArgs e)
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

        private void mi_teamInformation_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("data/teamNHT.txt");
                MessageBox.Show(text, "Thông tin nhóm", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Không thể đọc file! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mi_projectInfromation_Click(object sender, EventArgs e)
        {
            try
            {
                string text = System.IO.File.ReadAllText("data/projectInfo.txt");
                MessageBox.Show(text, "Thông tin sản phẩm", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Không thể đọc file! Vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mi_trogiup_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/thang.jurle");
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerTick.Stop();

            if (isExit)
            {
                MessageBox.Show("Nhấn OK để quay lại Menu!", "Thoát",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FormState.PreviousPage.Show();
                this.Hide();
                FormState.PreviousPage = this;
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát!", "Thoát",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dialog == DialogResult.OK)
                {
                    FormState.PreviousPage.Show();
                    this.Hide();
                    FormState.PreviousPage = this;
                }
                else
                {
                    timerTick.Start();
                    e.Cancel = true;
                }
            }
        }
    }
}
