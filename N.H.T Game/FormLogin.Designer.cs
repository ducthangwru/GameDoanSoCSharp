namespace N.H.T_Game
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_easy = new System.Windows.Forms.Button();
            this.bt_normal = new System.Windows.Forms.Button();
            this.bt_difficult = new System.Windows.Forms.Button();
            this.bt_highscore = new System.Windows.Forms.Button();
            this.bt_guild = new System.Windows.Forms.Button();
            this.lb_playmode = new System.Windows.Forms.Label();
            this.lb_function = new System.Windows.Forms.Label();
            this.bt_history = new System.Windows.Forms.Button();
            this.bt_delete_history = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_easy
            // 
            this.bt_easy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_easy.ForeColor = System.Drawing.Color.Teal;
            this.bt_easy.Location = new System.Drawing.Point(147, 66);
            this.bt_easy.Name = "bt_easy";
            this.bt_easy.Size = new System.Drawing.Size(150, 40);
            this.bt_easy.TabIndex = 0;
            this.bt_easy.Text = "Dễ";
            this.bt_easy.UseVisualStyleBackColor = true;
            this.bt_easy.Click += new System.EventHandler(this.bt_easy_Click);
            // 
            // bt_normal
            // 
            this.bt_normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_normal.ForeColor = System.Drawing.Color.Teal;
            this.bt_normal.Location = new System.Drawing.Point(147, 112);
            this.bt_normal.Name = "bt_normal";
            this.bt_normal.Size = new System.Drawing.Size(150, 40);
            this.bt_normal.TabIndex = 1;
            this.bt_normal.Text = "Trung bình";
            this.bt_normal.UseVisualStyleBackColor = true;
            this.bt_normal.Click += new System.EventHandler(this.bt_normal_Click);
            // 
            // bt_difficult
            // 
            this.bt_difficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_difficult.ForeColor = System.Drawing.Color.Teal;
            this.bt_difficult.Location = new System.Drawing.Point(147, 158);
            this.bt_difficult.Name = "bt_difficult";
            this.bt_difficult.Size = new System.Drawing.Size(150, 40);
            this.bt_difficult.TabIndex = 2;
            this.bt_difficult.Text = "Khó";
            this.bt_difficult.UseVisualStyleBackColor = true;
            this.bt_difficult.Click += new System.EventHandler(this.bt_difficult_Click);
            // 
            // bt_highscore
            // 
            this.bt_highscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_highscore.ForeColor = System.Drawing.Color.Teal;
            this.bt_highscore.Location = new System.Drawing.Point(49, 248);
            this.bt_highscore.Name = "bt_highscore";
            this.bt_highscore.Size = new System.Drawing.Size(150, 40);
            this.bt_highscore.TabIndex = 3;
            this.bt_highscore.Text = "Điểm cao";
            this.bt_highscore.UseVisualStyleBackColor = true;
            this.bt_highscore.Click += new System.EventHandler(this.bt_highscore_Click);
            // 
            // bt_guild
            // 
            this.bt_guild.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_guild.ForeColor = System.Drawing.Color.Teal;
            this.bt_guild.Location = new System.Drawing.Point(49, 294);
            this.bt_guild.Name = "bt_guild";
            this.bt_guild.Size = new System.Drawing.Size(150, 40);
            this.bt_guild.TabIndex = 4;
            this.bt_guild.Text = "Hướng dẫn chơi";
            this.bt_guild.UseVisualStyleBackColor = true;
            // 
            // lb_playmode
            // 
            this.lb_playmode.AutoSize = true;
            this.lb_playmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_playmode.ForeColor = System.Drawing.Color.Teal;
            this.lb_playmode.Location = new System.Drawing.Point(149, 32);
            this.lb_playmode.Name = "lb_playmode";
            this.lb_playmode.Size = new System.Drawing.Size(148, 20);
            this.lb_playmode.TabIndex = 5;
            this.lb_playmode.Text = "Chọn chế độ chơi";
            // 
            // lb_function
            // 
            this.lb_function.AutoSize = true;
            this.lb_function.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_function.ForeColor = System.Drawing.Color.Teal;
            this.lb_function.Location = new System.Drawing.Point(174, 215);
            this.lb_function.Name = "lb_function";
            this.lb_function.Size = new System.Drawing.Size(95, 20);
            this.lb_function.TabIndex = 6;
            this.lb_function.Text = "Chức năng";
            // 
            // bt_history
            // 
            this.bt_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_history.ForeColor = System.Drawing.Color.Teal;
            this.bt_history.Location = new System.Drawing.Point(244, 248);
            this.bt_history.Name = "bt_history";
            this.bt_history.Size = new System.Drawing.Size(150, 40);
            this.bt_history.TabIndex = 7;
            this.bt_history.Text = "Nhật ký chơi";
            this.bt_history.UseVisualStyleBackColor = true;
            this.bt_history.Click += new System.EventHandler(this.bt_history_Click);
            // 
            // bt_delete_history
            // 
            this.bt_delete_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_delete_history.ForeColor = System.Drawing.Color.Teal;
            this.bt_delete_history.Location = new System.Drawing.Point(244, 294);
            this.bt_delete_history.Name = "bt_delete_history";
            this.bt_delete_history.Size = new System.Drawing.Size(150, 40);
            this.bt_delete_history.TabIndex = 8;
            this.bt_delete_history.Text = "Xóa nhật ký chơi";
            this.bt_delete_history.UseVisualStyleBackColor = true;
            this.bt_delete_history.Click += new System.EventHandler(this.bt_delete_history_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(484, 348);
            this.Controls.Add(this.bt_delete_history);
            this.Controls.Add(this.bt_history);
            this.Controls.Add(this.lb_function);
            this.Controls.Add(this.lb_playmode);
            this.Controls.Add(this.bt_guild);
            this.Controls.Add(this.bt_highscore);
            this.Controls.Add(this.bt_difficult);
            this.Controls.Add(this.bt_normal);
            this.Controls.Add(this.bt_easy);
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_easy;
        private System.Windows.Forms.Button bt_normal;
        private System.Windows.Forms.Button bt_difficult;
        private System.Windows.Forms.Button bt_highscore;
        private System.Windows.Forms.Button bt_guild;
        private System.Windows.Forms.Label lb_playmode;
        private System.Windows.Forms.Label lb_function;
        private System.Windows.Forms.Button bt_history;
        private System.Windows.Forms.Button bt_delete_history;
    }
}

