﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        SqlConnection connect = new SqlConnection
            (@"Data Source=(local);Initial Catalog=
                QLDiem;Persist Security Info=True;User ID=sa;Password=ducthangwru");

        private string lines = "";
        private SqlDataAdapter sqlAdapter;
        private DataTable dataTable;

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
           
        }

        private void bt_history_Click(object sender, EventArgs e)
        {
            //if(new FileInfo("history.txt").Length == 0)
            //{
            //    MessageBox.Show("Không có nhật ký chơi!", "Nhật ký chơi",
            //        MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    string lines = System.IO.File.ReadAllText("history.txt");
            //    MessageBox.Show(lines, "Nhật ký chơi", MessageBoxButtons.OK);
            //}

            connectSQL("select * from NhatKyDiem");

            if(dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có nhật ký chơi!", "Nhật ký chơi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        lines += dataTable.Rows[i][j].ToString();
                        if (j == 2)
                            lines += " Điểm -";
                        else
                            lines += " - ";
                    }
                    lines += "\r\n";
                }

                DialogResult dialog = MessageBox.Show(lines, "Nhật ký chơi", MessageBoxButtons.OK);
                if (dialog == DialogResult.OK)
                {
                    lines = "";
                }
            }
            
            connect.Close();
        }

        private void bt_delete_history_Click(object sender, EventArgs e)
        {
            connectSQL("delete from NhatKyDiem");
            if (dataTable.Rows.Count == 0)
            {
                connect.Close();
                MessageBox.Show("Không có gì để xóa!", "Xóa nhật ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa nhật ký?", "Xóa nhật ký",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.OK)
                {
                    connectSQL("delete from NhatKyDiem");
                    connect.Close();
                    MessageBox.Show("Xóa thành công!", "Xóa nhật ký", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void connectSQL(string sql)
        {
            try
            {
                connect.Open();
                SqlCommand sqlcom = new SqlCommand(sql, connect);
                sqlcom.CommandType = CommandType.Text;
                sqlAdapter = new SqlDataAdapter(sqlcom);
                dataTable = new DataTable();
                sqlAdapter.Fill(dataTable);
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối. Vui lòng kiểm tra lại!", "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                SqlConnection connect = new SqlConnection
                (@"Data Source=(local);Initial Catalog=
                QLDiem;Persist Security Info=True;User ID=sa;Password=ducthangwru");
                connect.Close();
            }
        }
    }
}