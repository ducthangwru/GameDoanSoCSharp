using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private int x = 150;
        private int y = 95;
        private int a = 1;

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

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormState.PreviousPage.Show();
            this.Hide();
            FormState.PreviousPage = this;
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

                        DialogResult dialog = MessageBox.Show("Bạn có muốn chơi tiếp không?", "Chơi tiếp",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if(dialog == DialogResult.OK)
                        {
                            lb_sussgest.Text = "";
                            lb_random_number.Text = "";
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
            timerTick.Stop();
            DialogResult dialog = MessageBox.Show(
                "Nhấn OK để tiếp tục!", "Tạm dừng", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            if(dialog == DialogResult.OK)
            {
                timerTick.Start();
            }
        }

        private void bt_backmenu_Click(object sender, EventArgs e)
        {
            saveScore();
        }

        public void saveScore()
        {
            DialogResult dialogSave = MessageBox.Show("Bạn có muốn lưu điểm không?", "Lưu Điểm",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogSave == DialogResult.OK)
            {
                this.Close();
                FormSaveScore formSave = new FormSaveScore(score, coefficient);
                formSave.Show();
            }
            else
            {
                this.Close();
            }
        }


        public void reset()
        {
            timerTick.Start();
            lb_random_number.Text = "Đoán đi";
            timeCount = time;
        }

        private void mi_newgame_Click(object sender, EventArgs e)
        {
            timerTick.Stop();
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn chơi mới không?", "Chơi mới",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialog == DialogResult.OK)
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
            saveScore();
        }
    }
}
